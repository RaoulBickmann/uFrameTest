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
    
    
    public partial class DmgSystemBase : uFrame.ECS.Systems.EcsSystem {
        
        private IEcsComponentManagerOf<Health> _HealthManager;
        
        private IEcsComponentManagerOf<TestComponentNode> _TestComponentNodeManager;
        
        private IEcsComponentManagerOf<NewGroupNode> _NewGroupNodeManager;
        
        private DmgSystemOnMouseDownHandler DmgSystemOnMouseDownHandlerInstance = new DmgSystemOnMouseDownHandler();
        
        public IEcsComponentManagerOf<Health> HealthManager {
            get {
                return _HealthManager;
            }
            set {
                _HealthManager = value;
            }
        }
        
        public IEcsComponentManagerOf<TestComponentNode> TestComponentNodeManager {
            get {
                return _TestComponentNodeManager;
            }
            set {
                _TestComponentNodeManager = value;
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
            TestComponentNodeManager = ComponentSystem.RegisterComponent<TestComponentNode>(1);
            NewGroupNodeManager = ComponentSystem.RegisterGroup<NewGroupNodeGroup,NewGroupNode>();
            this.OnEvent<uFrame.ECS.UnityUtilities.MouseDownDispatcher>().Subscribe(_=>{ DmgSystemOnMouseDownFilter(_); }).DisposeWith(this);
        }
        
        protected virtual void DmgSystemOnMouseDownHandler(uFrame.ECS.UnityUtilities.MouseDownDispatcher data, Health source) {
            var handler = DmgSystemOnMouseDownHandlerInstance;
            handler.System = this;
            handler.Event = data;
            handler.Source = source;
            StartCoroutine(handler.Execute());
        }
        
        protected void DmgSystemOnMouseDownFilter(uFrame.ECS.UnityUtilities.MouseDownDispatcher data) {
            var SourceHealth = HealthManager[data.EntityId];
            if (SourceHealth == null) {
                return;
            }
            if (!SourceHealth.Enabled) {
                return;
            }
            this.DmgSystemOnMouseDownHandler(data, SourceHealth);
        }
    }
    
    [uFrame.Attributes.uFrameIdentifier("18d9ff8a-d414-411c-ac6f-221b11cfc4c1")]
    public partial class DmgSystem : DmgSystemBase {
        
        private static DmgSystem _Instance;
        
        public DmgSystem() {
            Instance = this;
        }
        
        public static DmgSystem Instance {
            get {
                return _Instance;
            }
            set {
                _Instance = value;
            }
        }
    }
}