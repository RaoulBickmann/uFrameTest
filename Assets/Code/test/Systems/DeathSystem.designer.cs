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
    
    
    public partial class DeathSystemBase : uFrame.ECS.Systems.EcsSystem {
        
        private IEcsComponentManagerOf<Health> _HealthManager;
        
        private IEcsComponentManagerOf<NewGroupNode> _NewGroupNodeManager;
        
        private DeathSystemDeathEventHandler DeathSystemDeathEventHandlerInstance = new DeathSystemDeathEventHandler();
        
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
            this.OnEvent<test.DeathEvent>().Subscribe(_=>{ DeathSystemDeathEventFilter(_); }).DisposeWith(this);
        }
        
        protected virtual void DeathSystemDeathEventHandler(test.DeathEvent data, Health sourceentity) {
            var handler = DeathSystemDeathEventHandlerInstance;
            handler.System = this;
            handler.Event = data;
            handler.SourceEntity = sourceentity;
            StartCoroutine(handler.Execute());
        }
        
        protected void DeathSystemDeathEventFilter(test.DeathEvent data) {
            var SourceEntityHealth = HealthManager[data.SourceEntity];
            if (SourceEntityHealth == null) {
                return;
            }
            if (!SourceEntityHealth.Enabled) {
                return;
            }
            this.DeathSystemDeathEventHandler(data, SourceEntityHealth);
        }
    }
    
    [uFrame.Attributes.uFrameIdentifier("852d03b7-d6cd-4797-8a13-72712eb59fc6")]
    public partial class DeathSystem : DeathSystemBase {
        
        private static DeathSystem _Instance;
        
        public DeathSystem() {
            Instance = this;
        }
        
        public static DeathSystem Instance {
            get {
                return _Instance;
            }
            set {
                _Instance = value;
            }
        }
    }
}
