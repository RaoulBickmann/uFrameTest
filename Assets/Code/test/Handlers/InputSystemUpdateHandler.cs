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
    
    
    public class InputSystemUpdateHandler {
        
        private uFrame.ECS.APIs.ISystemUpdate _Event;
        
        private uFrame.ECS.Systems.EcsSystem _System;
        
        private string ActionNode33_name = default( System.String );
        
        private string StringNode32 = "space";
        
        private bool ActionNode33_Result = default( System.Boolean );
        
        private bool ActionNode34_value = default( System.Boolean );
        
        private test.MenuToggleEvent PublishEventNode35_Result = default( test.MenuToggleEvent );
        
        public uFrame.ECS.APIs.ISystemUpdate Event {
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
            ActionNode33_name = StringNode32;
            // ActionNode
            while (this.DebugInfo("559a280a-52be-4fde-8a8f-40f9a23f8cc6","8dd5c55b-a711-4fbe-8023-2762a71bf72e", this) == 1) yield return null;
            // Visit UnityEngine.Input.GetKeyDown
            ActionNode33_Result = UnityEngine.Input.GetKeyDown(ActionNode33_name);
            ActionNode34_value = ActionNode33_Result;
            // ActionNode
            while (this.DebugInfo("8dd5c55b-a711-4fbe-8023-2762a71bf72e","4aca5600-0659-4dac-9ead-1d73ab413f3c", this) == 1) yield return null;
            // Visit uFrame.ECS.Actions.Comparisons.IsTrue
            uFrame.ECS.Actions.Comparisons.IsTrue(ActionNode34_value, ()=> { System.StartCoroutine(ActionNode34_yes()); }, ()=> { System.StartCoroutine(ActionNode34_no()); });
            yield break;
        }
        
        private System.Collections.IEnumerator ActionNode34_yes() {
            // PublishEventNode
            while (this.DebugInfo("4aca5600-0659-4dac-9ead-1d73ab413f3c","6b5662b6-0eda-4500-88ab-352311c0d5bf", this) == 1) yield return null;
            var PublishEventNode35_Event = new MenuToggleEvent();
            System.Publish(PublishEventNode35_Event);
            PublishEventNode35_Result = PublishEventNode35_Event;
            yield break;
        }
        
        private System.Collections.IEnumerator ActionNode34_no() {
            yield break;
        }
    }
}