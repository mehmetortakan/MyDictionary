using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] _arrayKey;
        TKey[] _tempArrayKey;
        TValue[] _arrayValue;
        TValue[] _tempArrayValue;

        public MyDictionary()
        {
            _arrayKey = new TKey[0];
            _arrayValue = new TValue[0];
        }

        public void Add(TKey key, TValue value)

        {
            _tempArrayKey = _arrayKey;
            _tempArrayValue = _arrayValue;
            _arrayKey = new TKey[_arrayKey.Length + 1];
            _arrayValue = new TValue[_arrayValue.Length + 1];

            for (int i = 0; i < _tempArrayKey.Length; i++)
            {
                _arrayKey[i] = _tempArrayKey[i];

            }
            for (int j = 0; j < _tempArrayValue.Length; j++)
            {
                _arrayValue[j] = _tempArrayValue[j];
            }

            _arrayKey[_arrayKey.Length - 1] = key;
            _arrayValue[_arrayKey.Length -1] = value;

        }



     

        public int CountKey
        {
            get { return _arrayKey.Length;}
            
        }

        public int CountValue
        {
            get { return _arrayValue.Length; }


        }

       
    }
}
