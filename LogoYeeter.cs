using Zenject;
using UnityEngine;
using System.Threading.Tasks;

namespace DeletusMetallica
{
    internal class LogoYeeter : IInitializable
    {
        //Vars
        private GameObject _metalGO;

        private GameObject _regularGO;

        private GameObject _nestedGO;

        private LogoYeeter(MenuEnvironmentManager environmentManager)
        {
            var MenuEnv = environmentManager.transform.Find("ThunderMenuEnvironment");

            //Get logo GameObjects
            _metalGO = MenuEnv.transform.Find("MetallicaLogo").gameObject;
            _regularGO = MenuEnv.transform.Find("BS_Logo").gameObject;
            _nestedGO = MenuEnv.transform.Find("BS_Logo/Logo").gameObject;
        }

        public async void Initialize()
        {
            if (_metalGO == null || _regularGO == null || _nestedGO == null)
            {
                //Do useless waiting thread if objects aren't found
                await Task.Delay(25);
            }

            _metalGO.SetActive(false);

            // Scale regular logo back and move it to the starting point
            _regularGO.transform.position = Vector3.zero;
            _regularGO.transform.localScale = Vector3.one;

            //Move nested logo back to the regular positon
            _nestedGO.transform.position = new Vector3(0.0f, 19.00f, 29.10f);
        }
    }
}
