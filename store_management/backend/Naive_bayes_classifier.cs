using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store_management.backend
{
    class Naive_bayes_classifier
    {
        Dictionary<int, Dictionary<string, double>> nb_scores;
        private string[] get_tokens_of_store_management_database(string[] data)
        {
            List<string> set_of_tokens = new List<string>();
            foreach (string item in data)
            {
                string[] data_tokens = item.Split(new char[] { ',', '_', ' ' },
                    StringSplitOptions.RemoveEmptyEntries); ;
                foreach (string token in data_tokens)
                {
                    if (!set_of_tokens.Contains(token)) set_of_tokens.Add(token);
                }
            }
            return set_of_tokens.ToArray();
        }
        private Dictionary<int,string[]> 
            store_management_data_preprocessing(string[] data)
        {
            Dictionary<int, string[]> processed_data =
                new Dictionary<int, string[]>();
            for (int i = 0; i < data.Length; i++)
            {
                string[] line = data[i].Split(new char[]{',','_',' '},
                    StringSplitOptions.RemoveEmptyEntries);
                processed_data.Add(i, line);
            }

            return processed_data;
        }
        private void model_build(int num_class,string[] data)
        {
            string[] set_of_tokens = get_tokens_of_store_management_database(data);
            nb_scores = new Dictionary<int, Dictionary<string, double>>();
            for (int i = 0; i < num_class; i++)
            {
                Dictionary<string, double> scores =
                    new Dictionary<string, double>();
                foreach (string token in set_of_tokens)
                {
                    scores.Add(token, 1/ (double)num_class);
                }
                nb_scores.Add(i, scores);
            }

        }
        public double[] fit(int num_class, string[] data)
        {
            model_build(num_class, data);
            Dictionary<int, string[]> processed_data =
                store_management_data_preprocessing(data);
            Dictionary<int, Dictionary<string, double>> _nb_scores =
            new Dictionary<int, Dictionary<string, double>>(nb_scores);

            foreach (
                KeyValuePair<int,Dictionary<string,double>> obj_tokens in _nb_scores)
            {
                Dictionary<string, double> _obj_tokens =
                    new Dictionary<string, double>(obj_tokens.Value);
                
                foreach (
                    KeyValuePair<string,double> token_score in _obj_tokens)
                {
                    if (processed_data[obj_tokens.Key].Contains(token_score.Key))
                    {
                        nb_scores[obj_tokens.Key][token_score.Key]
                            += 1 / (double)num_class;
                    }
                }
            }
            return nb_scores[0].Values.ToArray();
        }
        public Dictionary<int, double> normalization(
            Dictionary<int, double> prediction)
        {
            double sum = 0;
            Dictionary<int, double> _prediction = new Dictionary<int, double>(prediction);
            foreach (double item in prediction.Values)
            {
                sum += item;
            }
            foreach (KeyValuePair<int,double> keyValue in _prediction)
            {
                prediction[keyValue.Key] = prediction[keyValue.Key] / sum * 100;
            }
            return prediction;
        }
        private int[] sort_dict(Dictionary<int, double> dict_to_sort)
        {
            List<KeyValuePair<int, double>> myList = dict_to_sort.ToList();

            myList.Sort(
                delegate (KeyValuePair<int, double> pair1,
                KeyValuePair<int, double> pair2)
                {
                    return pair2.Value.CompareTo(pair1.Value);
                }
            );
            List<int> res = new List<int>();
            foreach (KeyValuePair<int, double> keyValue in myList)
            {
                if(keyValue.Value==myList[0].Value)
                    res.Add(keyValue.Key);
            }
            if (res.Count == myList.Count) return new int[0];
            return res.ToArray();
        } 
        public int[] predict(string[] query)
        {

            Dictionary<int, double> prediction = new Dictionary<int, double>();
            foreach (int key in nb_scores.Keys)
            {
                prediction.Add(key, 1);
            }

            foreach (
                KeyValuePair<int, Dictionary<string, double>> keyvalue in nb_scores)
            {
                foreach (
                    KeyValuePair<string, double> keyValuePair in keyvalue.Value)
                {
                    if (query.Contains(keyValuePair.Key))
                    {
                        prediction[keyvalue.Key] *= keyValuePair.Value;
                    }
                }
            }
            prediction = normalization(prediction);
            return sort_dict(prediction);
            
        }

    }
}
