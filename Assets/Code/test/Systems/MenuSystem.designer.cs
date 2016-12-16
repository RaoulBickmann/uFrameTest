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
    
    
    public partial class MenuSystemBase : uFrame.ECS.Systems.EcsSystem {
        
        private IEcsComponentManagerOf<Health> _HealthManager;
        
        private IEcsComponentManagerOf<MenuComponent> _MenuComponentManager;
        
        private IEcsComponentManagerOf<NewGroupNode> _NewGroupNodeManager;
        
        private MenuSystemMenuToggleEventHandler MenuSystemMenuToggleEventHandlerInstance = new MenuSystemMenuToggleEventHandler();
        
        private MenuSystemGameReadyHandler MenuSystemGameReadyHandlerInstance = new MenuSystemGameReadyHandler();
        
        public IEcsComponentManagerOf<Health> HealthManager {
            get {
                return _HealthManager;
            }
            set {
                _HealthManager = value;
            }
        }
        
        public IEcsComponentManagerOf<MenuComponent> MenuComponentManager {
            get {
                return _MenuComponentManager;
            }
            set {
                _MenuComponentManager = value;
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
            MenuComponentManager = ComponentSystem.RegisterComponent<MenuComponent>(4);
            NewGroupNodeManager = ComponentSystem.RegisterGroup<NewGroupNodeGroup,NewGroupNode>();
            this.OnEvent<test.MenuToggleEvent>().Subscribe(_=>{ MenuSystemMenuToggleEventFilter(_); }).DisposeWith(this);
            this.OnEvent<uFrame.Kernel.GameReadyEvent>().Subscribe(_=>{ MenuSystemGameReadyFilter(_); }).DisposeWith(this);
        }
        
        protected virtual void MenuSystemMenuToggleEventHandler(test.MenuToggleEvent data, MenuComponent group) {
            var handler = MenuSystemMenuToggleEventHandlerInstance;
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            StartCoroutine(handler.Execute());
        }
        
        protected void MenuSystemMenuToggleEventFilter(test.MenuToggleEvent data) {
            var MenuComponentItems = MenuComponentManager.Components;
            for (var MenuComponentIndex = 0
            ; MenuComponentIndex < MenuComponentItems.Count; MenuComponentIndex++
            ) {
                if (!MenuComponentItems[MenuComponentIndex].Enabled) {
                    continue;
                }
                this.MenuSystemMenuToggleEventHandler(data, MenuComponentItems[MenuComponentIndex]);
            }
        }
        
        protected virtual void MenuSystemGameReadyHandler(uFrame.Kernel.GameReadyEvent data, MenuComponent group) {
            var handler = MenuSystemGameReadyHandlerInstance;
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            StartCoroutine(handler.Execute());
        }
        
        protected void MenuSystemGameReadyFilter(uFrame.Kernel.GameReadyEvent data) {
            var MenuComponentItems = MenuComponentManager.Components;
            for (var MenuComponentIndex = 0
            ; MenuComponentIndex < MenuComponentItems.Count; MenuComponentIndex++
            ) {
                if (!MenuComponentItems[MenuComponentIndex].Enabled) {
                    continue;
                }
                this.MenuSystemGameReadyHandler(data, MenuComponentItems[MenuComponentIndex]);
            }
        }
    }
    
    [uFrame.Attributes.uFrameIdentifier("e6e98001-aeb9-43b0-ae0f-74647b369657")]
    public partial class MenuSystem : MenuSystemBase {
        
        private static MenuSystem _Instance;
        
        public MenuSystem() {
            Instance = this;
        }
        
        public static MenuSystem Instance {
            get {
                return _Instance;
            }
            set {
                _Instance = value;
            }
        }
    }
}
