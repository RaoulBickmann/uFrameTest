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
    using test;
    using uFrame.ECS;
    using uFrame.ECS.Components;
    using UniRx;
    
    
    [uFrame.Attributes.EventId(1)]
    public partial class DmgEvent : object {
        
        [UnityEngine.SerializeField()]
        private Int32 _DmgValue;
        
        [UnityEngine.SerializeField()]
        private Int32 _SourceEntity;
        
        public Int32 DmgValue {
            get {
                return _DmgValue;
            }
            set {
                _DmgValue = value;
            }
        }
        
        public Int32 SourceEntity {
            get {
                return _SourceEntity;
            }
            set {
                _SourceEntity = value;
            }
        }
    }
}
