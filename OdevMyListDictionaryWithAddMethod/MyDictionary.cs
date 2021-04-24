using System;
using System.Collections.Generic;
using System.Text;

namespace OdevMyDictionaryWithAddMethod
{
    class MyDictionary<K,V>
    {
        K[] Keys;
        V[] Values;
        public MyDictionary()
        {
            Keys = new K[0];
            Values = new V[0];
        }

        public void Add(K Key, V Value)
        {
            K[] tempKey = Keys;
            V[] tempValue = Values;

            Keys = new K[Keys.Length + 1];
            Values = new V[Values.Length + 1];
            for (int i = 0; i < Keys.Length; i++)
            {
                Keys[i] = tempKey[i];
            }
            for (int i = 0; i < Values.Length; i++)
            {
                Values[i] = tempValue[i];
            }
            Keys[Keys.Length - 1] = Key;
            Values[Values.Length - 1] = Value;
        }
    }
}
