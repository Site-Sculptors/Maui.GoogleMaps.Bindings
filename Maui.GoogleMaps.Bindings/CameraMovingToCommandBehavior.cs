

namespace Maui.GoogleMaps.Bindings
{
    [Preserve(AllMembers = true)]
    public sealed class CameraMovingToCommandBehavior : EventToCommandBehaviorBase
    {
        protected override void OnAttachedTo(Map bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.CameraMoving += OnCameraMoving;
        }

        protected override void OnDetachingFrom(Map bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.CameraMoving -= OnCameraMoving;
        }

        private void OnCameraMoving(object sender, CameraMovingEventArgs cameraMovingEventArgs)
        {
            Command?.Execute(cameraMovingEventArgs);
        }
    }
}
