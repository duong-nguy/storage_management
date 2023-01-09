// UI
const drawing_canvas = document.getElementById('canvas-drawing');
const predict_canvas = document.getElementById('canvas-predict');
const ctx_drawing = drawing_canvas.getContext('2d');
const ctx_predict = predict_canvas.getContext('2d');
ctx_predict.font = "80px Arial";
ctx_predict.textAlign = "center";
const clear_btn = document.getElementById('clear-button');
//draw
let mouse_pos = { x: 0, y: 0 };
let draw = false;
//predict
let model = tf.sequential();
const model_URLs = new Map([
    ['test_model',
    'https://raw.githubusercontent.com/duong-nguy/Mnist_classify/main/Mnist_classify/model.json']
]);
const labels = new Map([
    [0, '0'], [1, '1'], [2, '2'], [3, '3'], [4, '4'],
    [5, '5'], [6, '6'], [7, '7'], [8, '8'], [9, '9'],
    [10, 'A'], [11, 'B'], [12, 'C'], [13, 'D'], [14, 'E'],
    [15, 'F'], [16, 'G'], [17, 'H'], [18, 'I'], [19, 'J'],
    [20, 'K'], [21, 'L'], [22, 'M'], [23, 'N'], [24, 'O'], 
    [25, 'P'], [26, 'Q'], [27, 'R'], [28, 'S'], [29, 'T'],
    [30, 'U'], [31, 'V'], [32, 'W'], [33, 'X'], [34, 'Y'], 
    [35, 'Z'], [36, 'a'], [37, 'b'], [38, 'd'], [39, 'e'],
    [40, 'f'], [41, 'g'], [42, 'h'], [43, 'n'], [44, 'q'], 
    [45, 'r'], [46, 't']
]);
let model_is_load = false;

// add event listener to elements

document.addEventListener('mousedown', start_drawing);
document.addEventListener('mouseup', stop_drawing,make_prediction);
document.addEventListener('mousemove', drawing);
clear_btn.addEventListener('click', clear_canvas);

    


// load predicting model
async function load_model(model_name) {
    test_model = await tf.loadLayersModel(model_URLs.get('test_model'));
    model = test_model;
    model_is_load = true;
    console.log('model loaded')
    document.getElementById("h1").innerHTML = "Prediction model loaded";

}
// drawing
function get_mouse_pos(event) {
    mouse_pos.x = event.clientX - drawing_canvas.offsetLeft;
    mouse_pos.y = event.clientY - drawing_canvas.offsetTop;
    
}

function start_drawing(event) {
    draw = true;
    get_mouse_pos(event);
}

function stop_drawing(event) {
    draw = false;
    make_prediction();

}

function drawing(event) {
    if (!draw) return;
    ctx_drawing.beginPath();
    ctx_drawing.lineWidth = 50;
    ctx_drawing.lineCap = 'round';
    ctx_drawing.strokeStyle = 'orange';
    ctx_drawing.moveTo(mouse_pos.x, mouse_pos.y);
    get_mouse_pos(event);
    ctx_drawing.lineTo(mouse_pos.x , mouse_pos.y);
    ctx_drawing.stroke();

}

function clear_canvas() {
    ctx_predict.clearRect(0, 0,
        predict_canvas.width,
        predict_canvas.height);
    ctx_drawing.clearRect(0, 0,
        drawing_canvas.width,
        drawing_canvas.height);
}
function display_prediction(display_value){
    /*
        display_value.key
        display_value.confidence
    */
    ctx_predict.clearRect(0, 0,
        predict_canvas.width,
        predict_canvas.height);
    ctx_predict.fillText(
        `${labels.get(display_value.key)} ${display_value.confidence}%`,
        predict_canvas.width/2,
        predict_canvas.height/2); 
}
// vision
function make_prediction() {
    if (!model_is_load) {
        console.log('No model');
        return;
    }
    let image_tensor = tf.browser.fromPixels( 
        ctx_drawing.getImageData(
            0,0,drawing_canvas.width,drawing_canvas.height
            ))
            .mean(2)
            .toFloat()
            .expandDims(0)
            .expandDims(-1);
    image_tensor = tf.image.resizeBilinear(
        image_tensor,
        [28,28]
    );
    image_tensor = image_tensor.div(image_tensor.max());
    const prediction = model.predict(image_tensor);
    const display_value = {
        key:parseInt(prediction.argMax(-1).dataSync()),
        confidence:parseInt(prediction.max(-1).dataSync()*100)
    }
    display_prediction(display_value);

}

load_model();