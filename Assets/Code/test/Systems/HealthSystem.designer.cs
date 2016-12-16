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
    using uFrame.ECS.APIs;
    using uFrame.ECS.Components;
    using uFrame.ECS.Systems;
    using uFrame.Kernel;
    using UniRx;
    using UnityEngine;
    
    
    public partial class HealthSystemBase : uFrame.ECS.Systems.EcsSystem {
        
        private IEcsComponentManagerOf<Health> _HealthManager;
        
        private IEcsComponentManagerOf<NewGroupNode> _NewGroupNodeManager;
        
        private HealthSystemDmgEventHandler HealthSystemDmgEventHandlerInstance = new HealthSystemDmgEventHandler();
        
        public IEcsComponentManagerOf<Health> HealthManager {
            get {
                return _HealthManager;
            }
            set {
                _HealthManager = value;
            }
        }
        
        public IEcsComponentManagerOf<NewGroupNode> NewGroupNodeManager {
            get {
                return _NewGroupNodeManager;
            }
            set {
                _NewGroupNodeManager = value;
            }
        }
        
        public override void Setup() {
            base.Setup();
            HealthManager = ComponentSystem.RegisterComponent<Health>(2);
            NewGroupNodeManager = ComponentSystem.RegisterGroup<NewGroupNodeGroup,NewGroupNode>();
            this.OnEvent<test.DmgEvent>().Subscribe(_=>{ HealthSystemDmgEventFilter(_); }).DisposeWith(this);
        }
        
        protected virtual void HealthSystemDmgEventHandler(test.DmgEvent data, Health sourceentity) {
            var handler = HealthSystemDmgEventHandlerInstance;
            handler.System = this;
            handler.Event = data;
            handler.SourceEntity = sourceentity;
            StartCoroutine(handler.Execute());
        }
        
        protected void HealthSystemDmgEventFilter(test.DmgEvent data) {
            var SourceEntityHealth = HealthManager[data.SourceEntity];
            if (SourceEntityHealth == null) {
                return;
            }
            if (!SourceEntityHealth.Enabled) {
                return;
            }
            this.HealthSystemDmgEventHandler(data, SourceEntityHealth);
        }
    }
    
    [uFrame.Attributes.uFrameIdentifier("596c562c-351d-4995-82d5-77ce09a730a9")]
    public partial class HealthSystem : HealthSystemBase {
        
        private static HealthSystem _Instance;
        
        public HealthSystem() {
            Instance = this;
        }
        
        public static HealthSystem Instance {
            get {
                return _Instance;
            }
            set {
                _Instance = value;
            }
        }
    }
}
