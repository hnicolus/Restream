﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using OrchardCore.ContentManagement.Metadata.Models;
using OrchardCore.ContentTypes.Editors;
using OrchardCore.DisplayManagement.Views;
using OrchardCore.Environment.Shell;

namespace Restream.OrchardCore.Settings
{
    public class RestreamPartSettingsDisplayDriver : ContentTypePartDefinitionDisplayDriver
    {
      
    //    public override IDisplayResult Edit(ContentTypePartDefinition contentTypePartDefinition)
    //    {
    //        if (!String.Equals(nameof(RestreamPart), contentTypePartDefinition.PartDefinition.Name, StringComparison.Ordinal))
    //        {
    //            return null;
    //        }

    //        return Initialize<RestreamPartSettingsViewModel>("RestreamPartSettings_Edit", model =>
    //        {
    //            var settings = contentTypePartDefinition.GetSettings<RestreamPartSettings>();

    //            model.Token = settings.Token; 
    //            model.UseSettingsToken = settings.UseSettingsToken;
    //            model.RestreamPartSettings = settings;

    //        }).Location("Content");
    //    }

    //    public override async Task<IDisplayResult> UpdateAsync(ContentTypePartDefinition contentTypePartDefinition, UpdateTypePartEditorContext context)
    //    {


    //        if (!String.Equals(nameof(RestreamPart), contentTypePartDefinition.PartDefinition.Name, StringComparison.Ordinal))
    //        {
    //            return null;
    //        }

  
    //            var model = new RestreamPartSettingsViewModel();

    //            if (await context.Updater.TryUpdateModelAsync(model, Prefix, m => m.Token,m=>m.UseSettingsToken ))
    //            {
    //                context.Builder.WithSettings(new RestreamPartSettings { Token = model.Token, UseSettingsToken = model.UseSettingsToken });
    //            }
       

    //        return Edit(contentTypePartDefinition, context.Updater);
    //    }
    //
    }
}
