using System;
using System.Collections.Generic;
using Rich.Base.Runtime.Abstract.View;
using Rich.Base.Runtime.Extensions;
using Runtime.Data.ValueObject;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace Runtime.Views
{
    public class InputView : RichView, IEventSystemHandler
    {
        #region Unity Actions

        public UnityAction<float, float> onMovementInputTaken = delegate { };

        public UnityAction<Vector3> onRotationInputTaken = delegate { };

        #endregion

        [Space]

        #region Self Variables

        #region Public Variables

        [Header("Data")]
        public InputVO Vo;

        [Space] public bool IsAvailableForTouch = true;

        #endregion

        #region Private Variables

        #endregion

        #endregion

        private void Update()
        {
            if (!IsAvailableForTouch) return;

            onRotationInputTaken?.Invoke(new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")));

            if (Input.anyKey)
                onMovementInputTaken?.Invoke(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        }
        
        
    }
}