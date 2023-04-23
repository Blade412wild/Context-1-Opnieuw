//using DG.Tweening;
using UnityEngine;
using UnityEngine.UIElements;

namespace _01_Scripts.Bryan
{
    public class ArtistSkillRaycast : MonoBehaviour
    {
        [SerializeField] private Transform _shootRayFromHere;
        //[SerializeField] private Transform _spawnPoint;
        [SerializeField] private GameObject _obstaclePrefab;
        [SerializeField] private GameObject _truePathPrefab;


        // Start is called before the first frame update
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
            ChangeCube();
        }

        private void ChangeCube()
        {
            if (gameObject.CompareTag("Artist"))
            {
                
                RaycastHit hit;
                Ray ray = new Ray(_shootRayFromHere.transform.position, _shootRayFromHere.transform.forward);

                Debug.DrawRay(_shootRayFromHere.transform.position, _shootRayFromHere.transform.forward * 2f, Color.red);

                if (Physics.Raycast(ray, out hit, maxDistance: 2f))
                {
                    if (hit.transform.gameObject.GetComponent<Obstacle>())
                    {
                        Destroy(hit.transform.gameObject);
                        Instantiate(_obstaclePrefab, hit.transform.position, hit.transform.rotation);
                        return;
                    }

                    if (hit.transform.gameObject.GetComponent<TruePath>())
                    {
                        Destroy(hit.transform.gameObject);
                        Instantiate(_truePathPrefab, hit.transform.position, hit.transform.rotation);
                        return;
                    }
                }

                RaycastHit hit1;
                Ray ray1 = new Ray(_shootRayFromHere.transform.position, _shootRayFromHere.transform.right);

                Debug.DrawRay(_shootRayFromHere.transform.position, _shootRayFromHere.transform.right * 2f, Color.green);

                if (Physics.Raycast(ray1, out hit1, maxDistance: 2f))
                {
                    if (hit1.transform.gameObject.GetComponent<Obstacle>())
                    {
                        Destroy(hit1.transform.gameObject);
                        Instantiate(_obstaclePrefab, hit1.transform.position, hit1.transform.rotation);
                        return;
                    }

                    if (hit1.transform.gameObject.GetComponent<TruePath>())
                    {
                        Destroy(hit1.transform.gameObject);
                        Instantiate(_truePathPrefab, hit1.transform.position, hit1.transform.rotation);
                        return;
                    }
                }

                RaycastHit hit2;
                Ray ray2 = new Ray(_shootRayFromHere.transform.position, -_shootRayFromHere.transform.right);

                Debug.DrawRay(_shootRayFromHere.transform.position, -_shootRayFromHere.transform.right * 2f, Color.blue);

                if (Physics.Raycast(ray2, out hit2, maxDistance: 2f))
                {
                    if (hit2.transform.gameObject.GetComponent<Obstacle>())
                    {
                        Destroy(hit2.transform.gameObject);
                        Instantiate(_obstaclePrefab, hit2.transform.position, hit2.transform.rotation);
                        return;
                    }

                    if (hit2.transform.gameObject.GetComponent<TruePath>())
                    {
                        Destroy(hit2.transform.gameObject);
                        Instantiate(_truePathPrefab, hit2.transform.position, hit2.transform.rotation);
                        return;
                    }
                }
            }
        }
    }
}