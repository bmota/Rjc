﻿using Abp.Authorization;
using Abp.Localization;
using Abp.Notifications;
using Cloud.Rjc.Authorization;

namespace Cloud.Rjc.Notifications
{
    public class AppNotificationProvider : NotificationProvider
    {
        public override void SetNotifications(INotificationDefinitionContext context)
        {
            context.Manager.Add(
                new NotificationDefinition(
                    AppNotificationNames.NewUserRegistered,
                    displayName: L("NewUserRegisteredNotificationDefinition"),
                    permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_Users)
                    )
                );

            context.Manager.Add(
                new NotificationDefinition(
                    AppNotificationNames.NewTenantRegistered,
                    displayName: L("NewTenantRegisteredNotificationDefinition"),
                    permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Tenants)
                    )
                );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, AbpZeroTemplateConsts.LocalizationSourceName);
        }
    }
}
