using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Smthhere
    {
        private  List<int> _ints;
        private  string _name;
        private List<string> _strings;
        public Smthhere()
        {
            _ints = new List<int>();
            _name = "smth";
        }
        private Smthhere(Smthhere smth)
        {
            this._ints = new List<int>();
            this._ints.AddRange(smth._ints);
            this._name = smth._name;
            this._strings = new List<string>();
            this._strings.AddRange(smth._strings);

        }
        public Smthhere Copy()
        {
          return new Smthhere(this);
        }
        public void Clear()
        {
            this._ints = null;
            this._name = null;
        }
        public void InicializationAndOperation()
        {
            if (_strings != null) _strings.Add("Egor");
            else
            {
                _strings = new List<string>();
                _strings.Add("Egor");
            }
        }
    }
}
