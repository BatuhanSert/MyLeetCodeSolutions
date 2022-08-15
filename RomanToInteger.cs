public class Solution {
    public Dictionary<char, int> acceptable_char = new Dictionary<char, int>()
        {            
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000},                        
        };
    Queue<int> str_queue = new Queue<int>();
    public int RomanToInt(string s) 
    {
        if (s.Length >= 1 && s.Length <= 15)
        {
            var value = s.ToUpper();


            if (compare_acceptable_char_and_enqueu(value))
            {
                var tpm_int_value = str_queue.Dequeue();
                var sum_int_values = tpm_int_value;

                foreach (var integer_value in str_queue)
                {
                    if (integer_value <= tpm_int_value)
                    {
                        sum_int_values += integer_value;
                    }
                    else
                    {
                        sum_int_values -= tpm_int_value;
                        sum_int_values += integer_value - tpm_int_value;
                    }

                    tpm_int_value = integer_value;
                }
                return sum_int_values;
            }
            else
            {
                return -1;
            }
        }

        else
        {
            return -1;
        }                    
    }
    
    
    public bool compare_acceptable_char_and_enqueu(string s)
    {
        bool controller = false;
        str_queue.Clear();
        foreach (var chr in s)
        {
            foreach (var char_item in acceptable_char.Keys)
            {
                if (chr == char_item)
                {
                    controller = true;
                    str_queue.Enqueue(acceptable_char[char_item]);

                    break;
                }
                else
                {
                    controller = false;
                }
            }
        }
        
        return controller;
    }    
}