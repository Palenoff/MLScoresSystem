using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp.CrossValidation
{
    public class CVObject
    {
        string _type;
        int _n_splits;
        int _n_groups;
        int _p;
        bool _shuffle;
        object _train_size;
        object _test_size;

        public CVObject(string type)
        {
            Type = type;
            if (type == "KFold")
                N_splits = 3;
        }

        public CVObject(string type, string n_splits) : this(type)
        {
            int n_sp = Int32.Parse(n_splits);
            if (n_sp < 2)
                throw new ArgumentOutOfRangeException("n_splits", "Количество разбиений должно быть не меньше двух!");
            N_splits = n_sp;
        }

        public CVObject(string type, string n_splits, bool shuffle) : this(type)
        {
            int n_sp = Int32.Parse(n_splits);
            if (n_sp < 2)
                throw new ArgumentOutOfRangeException("n_splits", "Количество разбиений должно быть не меньше двух!");
            N_splits = n_sp;
            Shuffle = shuffle;
        }

        public CVObject(string type, string n_splits, string n_groups, string p, bool shuffle, string train, string test, bool n_splist_enabled, bool n_groups_enabled, bool train_enabled, bool test_enabled, bool p_enabled)
        {
            Type = type;
            if (type == "LeavePOut" && p == "")
                throw new ArgumentException("Для стратегии LeavePOut параметр P должен быть задан!");
            if (type == "LeavePGroupsOut" && n_groups == "")
                throw new ArgumentException("Для стратегии LeavePGroupsOut rоличество групп для тестовой выборки должн0 быть задано!");
            if (n_splits != "" && n_splist_enabled)
            {
                int n_sp = Int32.Parse(n_splits);
                if (n_sp < 2)
                    throw new ArgumentException("Количество разбиений должно быть не меньше двух!");
                N_splits = n_sp;
            }
            if (n_groups != "" && n_groups_enabled)
            {
                int n_gr = Int32.Parse(n_groups);
                if (n_gr < 0)
                    throw new ArgumentException("Количество групп для тестовой выборки должно быть положительным!");
                N_groups = n_gr;
            }
            if (p != "" && p_enabled)
            {
                int p_num = Int32.Parse(p);
                if (p_num < 0)
                    throw new ArgumentException("Параметр p должен быть положительным!");
                P = p_num;
            }
            Shuffle = shuffle;
            if (train != "" && train_enabled)
            {
                try
                {
                    Train_size = Int32.Parse(train);
                }
                catch (Exception e)
                {
                    Train_size = Double.Parse(train.Replace(".",","));
                }
            }
            if (test != "" && test_enabled)
            {
                try
                {
                    Test_size = Int32.Parse(test);
                }
                catch(Exception e)
                {
                    Test_size = Double.Parse(test.Replace(".", ","));
                }
            }
        }

        public string Type { get => _type; set => _type = value; }
        public int N_splits { get => _n_splits; set => _n_splits = value; }
        public int N_groups { get => _n_groups; set => _n_groups = value; }
        public int P { get => _p; set => _p = value; }
        public bool Shuffle { get => _shuffle; set => _shuffle = value; }
        public object Train_size { get => _train_size; set => _train_size = value; }
        public object Test_size { get => _test_size; set => _test_size = value; }
    }
}
