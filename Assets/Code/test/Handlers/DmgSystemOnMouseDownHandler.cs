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
    
    
    public class DmgSystemOnMouseDownHandler {
        
        public Health Source;
        
        private uFrame.ECS.UnityUtilities.MouseDownDispatcher _Event;
        
        private uFrame.ECS.Systems.EcsSystem _System;
        
        private int IntNode3 = 1;
        
        private test.DmgEvent PublishEventNode16_Result = default( test.DmgEvent );
        
        public uFrame.ECS.UnityUtilities.MouseDownDispatcher Event {
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
            // PublishEventNode
            while (this.DebugInfo("4e748bde-28c0-4d8c-8744-01a5793e7f74","8c69d3e8-48ec-4ca0-b56c-457348fa1617", this) == 1) yield return null;
            var PublishEventNode16_Event = new DmgEvent();
            PublishEventNode16_Event.DmgValue = IntNode3;
            PublishEventNode16_Event.SourceEntity = Source.EntityId;
            System.Publish(PublishEventNode16_Event);
            PublishEventNode16_Result = PublishEventNode16_Event;
            yield break;
        }
    }
}
