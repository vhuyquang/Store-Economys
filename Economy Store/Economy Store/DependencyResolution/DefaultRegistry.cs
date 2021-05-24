// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DefaultRegistry.cs" company="Web Advanced">
// Copyright 2012 Web Advanced (www.webadvanced.com)
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0

// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace ES.Web.DependencyResolution
{
    using ES.Services.Interface;
    using StructureMap;
    using StructureMap.Configuration.DSL;
    using StructureMap.Graph;
    using StructureMap.Graph.Scanning;
    using StructureMap.TypeRules;
    using System.Linq;
    using System.Web.Services.Description;

    public class DefaultRegistry : Registry
    {
        #region Constructors and Destructors

        public DefaultRegistry()
        {
            Scan(
                scan =>
                {
                    scan.TheCallingAssembly();
                    scan.WithDefaultConventions();
                   // scan.With(new ControllerConvention());
                });
          //  For<IProductService>().Use<IProductService>();
        }

        #endregion

    }
    internal class CommonSingeltonConvention : IRegistrationConvention
    {
        public void ScanTypes(TypeSet types, Registry registry)
        {
            var foundTypes = types.FindTypes(TypeClassification.Concretes | TypeClassification.Closed).ToList();
            foundTypes.ForEach(type =>
            {
                if (type.IsInterface) return;
                var interfaceType = type.AllInterfaces().FirstOrDefault();
                if (interfaceType is null) return;
                registry.For(interfaceType).Use(type).Singleton();
            });
        }
    }
}