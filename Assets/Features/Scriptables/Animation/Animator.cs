using UnityEngine;

namespace Features.Scriptables.Animation
{
    abstract class Animator<T> : ScriptableObject
    {
        public abstract void Animate(T target);
    }
}