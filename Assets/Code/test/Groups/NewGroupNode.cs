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
    using uFrame.Kernel;
    using UniRx;
    
    
    [uFrame.Attributes.ComponentId(1)]
    public partial class NewGroupNode : uFrame.ECS.Components.GroupItem {
        
        private Health _Health;
        
        public Health Health {
            get {
                return _Health;
            }
            set {
                _Health = value;
            }
        }
        
        public override int ComponentId {
            get {
                return 1;
            }
        }
    }
}
