﻿using Android.App;
using Android.App.Admin;
using Android.Content;
using Android.Widget;


[BroadcastReceiver(Permission = "android.permission.BIND_DEVICE_ADMIN")]
[MetaData("android.app.device_admin", Resource = "@xml/device_admin")]
[IntentFilter(new[] { "android.app.action.DEVICE_ADMIN_ENABLED", Intent.ActionMain })]
public class DeviceAdmin : DeviceAdminReceiver
{
    public override void OnEnabled(Context context, Intent intent)
    {
        base.OnEnabled(context, intent);
        Toast.MakeText(context, "DeviceAdmin", ToastLength.Short).Show();
    }
    public override void OnDisabled(Context context, Intent intent)
    {
        base.OnDisabled(context, intent);
    }

    public override void OnPasswordChanged(Context context, Intent intent)
    {
        base.OnPasswordChanged(context, intent);
    }

    public override void OnPasswordFailed(Context context, Intent intent)
    {
        base.OnPasswordFailed(context, intent);
    }
    public override void OnPasswordSucceeded(Context context, Intent intent)
    {
        base.OnPasswordSucceeded(context, intent);
    }
    
}