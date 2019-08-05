using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Auto.Startup.RNAutoStartup
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNAutoStartupModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNAutoStartupModule"/>.
        /// </summary>
        internal RNAutoStartupModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNAutoStartup";
            }
        }
    }
}
