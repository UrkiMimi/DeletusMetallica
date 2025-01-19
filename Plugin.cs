using IPA;
using IPALogger = IPA.Logging.Logger;
using SiraUtil.Zenject;
using DeletusMetallica.Installers;


namespace DeletusMetallica
{
    [Plugin(RuntimeOptions.SingleStartInit)]
    public class Plugin
    {
        internal static Plugin Instance { get; private set; }
        internal static IPALogger Log { get; private set; }

        [Init]
        public void Init(IPALogger logger, Zenjector zenjector)
        {
            Instance = this;
            Log = logger;
            Log.Info("DeletusMetallica initialized.");

            // Inject mod to logo thing
            zenjector.Install<MenuInstaller>(Location.Menu);
            Log.Info("Attempted to inject LogoYeeter into menu.");
        }
    }
}
