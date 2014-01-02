using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionLib
{
    public enum ActionCode
    { 
        Success,
        Fail,
        Exception
    }

    public class ActionLib
    {
        private delegate int Action(List<String> Parameter = null);

        public ActionLib()
        {
            #region _AA00000000001
            Action _AA00000000001 = delegate(List<String> Parameter)
            {
                return (int)ActionCode.Success;
            };
            #endregion

            this._ActionDatabase.Add("Null", _AA00000000001);
        }

        public Boolean addActionFunction(String _FunctionKey, Func<List<String>, int> _FunctionPoint)
        {
            Delegate TargetFunction = null;
            if (this._ActionDatabase.TryGetValue(_FunctionKey, out TargetFunction))
            {
                Log.WriteLine("[Error] add action function fail, function is already exist!");
                return false;
            }
            else
            {
                this._ActionDatabase.Add(_FunctionKey, _FunctionPoint);
                return true;
            }
        }

        public Delegate getActionFunction(String _FunctionKey)
        {
            Delegate TargetFunction = null;

            if (this._ActionDatabase.TryGetValue(_FunctionKey, out TargetFunction))
            {
                Log.WriteLine("get action function success = " + _FunctionKey);
                return TargetFunction;
            }

            Log.WriteLine("[Error] get action function fail");
            return null;
        }

        private Dictionary<String, Delegate> _ActionDatabase = new Dictionary<String, Delegate>();
    }
}
