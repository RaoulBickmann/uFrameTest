// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace test {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS;
    using uFrame.ECS.UnityUtilities;
    using uFrame.Kernel;
    using UnityEngine;
    
    
    public class HealthSystemDmgEventHandler {
        
        public Health SourceEntity;
        
        private test.DmgEvent _Event;
        
        private uFrame.ECS.Systems.EcsSystem _System;
        
        private int ActionNode14_a = default( System.Int32 );
        
        private int ActionNode14_b = default( System.Int32 );
        
        private int ActionNode14_Result = default( System.Int32 );
        
        public test.DmgEvent Event {
            get {
                return _Event;
            }
            set {
                _Event = value;
            }
        }
        
        public uFrame.ECS.Systems.EcsSystem System {
            get {
                return _System;
            }
            set {
                _System = value;
            }
        }
        
        public virtual System.Collections.IEnumerator Execute() {
            ActionNode14_a = SourceEntity.HealthValue;
            ActionNode14_b = Event.DmgValue;
            // ActionNode
            while (this.DebugInfo("","9bc983a9-1004-44cf-8efa-6317bb6adb97", this) == 1) yield return null;
            // Visit uFrame.ECS.Actions.IntLibrary.Subtract
            ActionNode14_Result = uFrame.ECS.Actions.IntLibrary.Subtract(ActionNode14_a, ActionNode14_b);
            // SetVariableNode
            while (this.DebugInfo("9bc983a9-1004-44cf-8efa-6317bb6adb97","a19e13ba-2ed8-4a9d-832c-d9a989304ed1", this) == 1) yield return null;
            SourceEntity.HealthValue = (System.Int32)ActionNode14_Result;
            yield break;
        }
    }
}
