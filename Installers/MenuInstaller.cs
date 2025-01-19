using Zenject;
using UnityEngine;
using System.ComponentModel;

namespace DeletusMetallica.Installers
{
    internal class MenuInstaller : Installer
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesTo<LogoYeeter>().AsSingle();
        }
    }
}
