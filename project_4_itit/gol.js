canvas = document.getElementById('canvas');
ctx = canvas.getContext('2d');
start_btn = document.getElementById('start-btn');
rand_btn = document.getElementById('rand-btn');
update_btn = document.getElementById('update-button');

reproduceSlider = document.getElementById("reproduce-slider");
deadSlider = document.getElementById("dead-slider");
timeSlider = document.getElementById("time-slider");


const screen_size = { w: canvas.width, h: canvas.height };
const cell_size = 5;
const init_cells = 2000;
const world_grid = {
    r: parseInt(screen_size.w / cell_size),
    c: parseInt(screen_size.h / cell_size)
};
let offsets = [];
let rules = { 
    reproduce: parseInt(reproduceSlider.value),
    dead: parseInt(deadSlider.value) 
};
let time_step = 100;
let start = false;
let alive_cells = new Set();
start_btn.addEventListener('click', ()=>{
    start = !start;
    if (start){
        start_btn.value = "Stop";
        start_btn.style="background-color: red; border-radius: 15%;" ;
    }
    else{
        start_btn.value = "Start";
        start_btn.style="background-color: green; border-radius: 15%;" ;
    }
            
});
document.getElementById('btn-apply')
    .addEventListener('click', ()=>{
        if(document.getElementById('sel-rules')
        .value =="moore"){
            get_moore_neighborhood_offsets(
                parseInt(document.getElementById('num-radius').value)
            )
        }
        else {
            get_von_noumann_neighborhood_offsets(
                parseInt(document.getElementById('num-radius').value)  
            )   
        }
        init_cells = parseInt(document.getElementById('num-init-cells').value)
        deadSlider.max = offsets.length
        reproduceSlider.max = offsets.length
    })
rand_btn.addEventListener('click', ()=>{
    alive_cells.clear();
    world_init();
});

reproduceSlider.addEventListener('change',()=>{
    rules.reproduce = parseInt(reproduceSlider.value);
})
deadSlider.addEventListener('change',()=>{
    rules.dead = parseInt(deadSlider.value);
})
timeSlider.addEventListener('change',()=>{
    time_step = parseInt(timeSlider.value);
    clearInterval(interval);
    interval = setInterval(game_step,time_step);
})

// start of backend
function add_live_cell(cell) {
    if (isNaN(cell)) return;
    cell_offset = Math.floor(Math.random() * 8);
    new_cell = cell + offsets[cell_offset];
    if (new_cell<0) {
        new_cell += (world_grid.c*world_grid.r);
    }
    else if (new_cell > (world_grid.c*world_grid.r)){
        new_cell -= (world_grid.c*world_grid.r);
    }
    alive_cells.add(new_cell);
}

function world_init() {
    min = 0;
    max = world_grid.r * world_grid.c;
    for (let index = 0; index < init_cells; index++) {
        cell = Math.floor(Math.random() * max)
        alive_cells.add(cell);
    }
}
function get_moore_neighborhood_offsets(radius){
    //chebyshev distance
    offsets = [];
    for (let i = - radius; i <= radius; i++){
        for (let j = -radius; j <= radius; j++)
        {
            num = i*world_grid.c + j;
            if (num!=0) offsets.push(num);
        }
            
    }
}
function get_von_noumann_neighborhood_offsets(radius){
    //manhattan distance
    offsets = [];
    for (let i = - radius; i <= radius; i++){
        for (let j = -radius; j <= radius; j++)
                if ((Math.abs(i)+Math.abs(j))<=radius){
                    num = i*world_grid.c + j;
                    if (num!=0) offsets.push(num);
            }
    }
}



function apply_rules() {
    this_state = alive_cells;
    for (const cell of this_state) {
        counter = 0;
        for (const offset of offsets) {
            neighbor = cell + offset;
            if (neighbor<0) {
                neighbor += (world_grid.c*world_grid.r);
            }
            else if (neighbor > (world_grid.c*world_grid.r)){
                neighbor -= (world_grid.c*world_grid.r);
            }
            if(this_state.has(neighbor)){
                counter++;
            }

        }
         if (counter < rules.reproduce) {
            alive_cells.delete(cell);
        }
        else if (counter > rules.dead) {
            alive_cells.delete(cell);
        }
        else if (counter == rules.reproduce) {
            add_live_cell(cell);
        }
    }
}


// end of backend
// start of Gui
function render_alive_cells() {

    ctx.clearRect(0, 0,
        canvas.width,
        canvas.height);
    for (const cell of alive_cells) {
        x = parseInt(cell / world_grid.c)
        y = cell % world_grid.c

        ctx.fillRect(
            x * cell_size,
            y * cell_size,
            cell_size,
            cell_size
        );
    }
    ctx.stroke();
}
// end of Gui
// main loop
function game_step() {
    if (!start) return;
    apply_rules();
    render_alive_cells();
    

}

get_von_noumann_neighborhood_offsets(1);
world_init();
render_alive_cells();
let interval = setInterval(game_step,time_step);
