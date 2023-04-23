using System.Collections.Generic;
using _01_Scripts.Bryan.Grid;
using UnityEngine;

namespace _01_Scripts.Bryan.ArtistSkill
{
    public class MeshSwapModel
    {
        public Mesh Mesh;
        public Material Material;
    }
    
    public class ArtistSkillRaycast : MonoBehaviour
    {
        //[SerializeField] private Transform _shootRayFromHere;
        //[SerializeField] private Transform _spawnPoint;
        [SerializeField] private Mesh _obstacleMesh;
        [SerializeField] private Mesh _walkableMesh;
        [SerializeField] private Material _obstacleMaterial;
        [SerializeField] private Material _walkableMaterial;

        [SerializeField] private List<Pillar> _pillars = new List<Pillar>();

        private SimpleGrid<MeshSwapModel> _simpleGrid = new SimpleGrid<MeshSwapModel>();

        // Start is called before the first frame update
        void Start()
        {
            var walkableModel = new MeshSwapModel
            {
                Material = _walkableMaterial,
                Mesh = _walkableMesh
            };
            
            var obstacleModel = new MeshSwapModel
            {
                Material = _obstacleMaterial,
                Mesh = _obstacleMesh
            };
            
            _simpleGrid.LoadGrid(4); 
            _simpleGrid.SetData(0, walkableModel);
            _simpleGrid.SetData(1, walkableModel);
            _simpleGrid.SetData(2, walkableModel);
            _simpleGrid.SetData(3, walkableModel);
            _simpleGrid.SetData(4, obstacleModel);
            _simpleGrid.SetData(5, obstacleModel);
            _simpleGrid.SetData(6, obstacleModel);
            _simpleGrid.SetData(7, walkableModel);
            _simpleGrid.SetData(8, obstacleModel);
            _simpleGrid.SetData(9, obstacleModel);
            _simpleGrid.SetData(10, obstacleModel);
            _simpleGrid.SetData(11, walkableModel);
            _simpleGrid.SetData(12, obstacleModel);
            _simpleGrid.SetData(13, obstacleModel);
            _simpleGrid.SetData(14, obstacleModel);
            _simpleGrid.SetData(15, walkableModel);

            foreach (var pillar in _pillars)
            {
                pillar.AddPillarActivatedHandler(OnPillarActivatedHandler);
            }
        }

        private void OnPillarActivatedHandler(int index)
        {
            var neighbours = _simpleGrid.GetNeighbours(index);
            foreach (var neighbour in neighbours)
            {
                var value = _simpleGrid.GetData(neighbour);
                _pillars[neighbour].UpdateModel(value);
                _pillars[neighbour].SwapModel();
                
                print(neighbour);
            }
            
            
            Debug.Log($"I jumped on pillar { index}");
        }

        // Update is called once per frame
        void Update()
        {
            foreach (var pillar in _pillars)
            {
                var isOn = _simpleGrid.GetData(pillar.Index);
                pillar.UpdateModel(isOn);
            }

            //ChangeCube();
        }

        // private void ChangeCube()
        // {
        //     if (gameObject.CompareTag("Artist"))
        //     {
        //         RaycastHit hit;
        //         Ray ray = new Ray(_shootRayFromHere.transform.position, _shootRayFromHere.transform.forward);
        //
        //         Debug.DrawRay(_shootRayFromHere.transform.position, _shootRayFromHere.transform.forward * 2f, Color.red);
        //
        //         if (Physics.Raycast(ray, out hit, maxDistance: 2f))
        //         {
        //             if (hit.transform.gameObject.GetComponent<Obstacle>())
        //             {
        //                 Destroy(hit.transform.gameObject);
        //                 Instantiate(_obstaclePrefab, hit.transform.position, hit.transform.rotation);
        //                 return;
        //             }
        //
        //             if (hit.transform.gameObject.GetComponent<TruePath>())
        //             {
        //                 Destroy(hit.transform.gameObject);
        //                 Instantiate(_truePathPrefab, hit.transform.position, hit.transform.rotation);
        //                 return;
        //             }
        //         }
        //
        //         RaycastHit hit1;
        //         Ray ray1 = new Ray(_shootRayFromHere.transform.position, _shootRayFromHere.transform.right);
        //
        //         Debug.DrawRay(_shootRayFromHere.transform.position, _shootRayFromHere.transform.right * 2f, Color.green);
        //
        //         if (Physics.Raycast(ray1, out hit1, maxDistance: 2f))
        //         {
        //             if (hit1.transform.gameObject.GetComponent<Obstacle>())
        //             {
        //                 Destroy(hit1.transform.gameObject);
        //                 Instantiate(_obstaclePrefab, hit1.transform.position, hit1.transform.rotation);
        //                 return;
        //             }
        //
        //             if (hit1.transform.gameObject.GetComponent<TruePath>())
        //             {
        //                 Destroy(hit1.transform.gameObject);
        //                 Instantiate(_truePathPrefab, hit1.transform.position, hit1.transform.rotation);
        //                 return;
        //             }
        //         }
        //
        //         RaycastHit hit2;
        //         Ray ray2 = new Ray(_shootRayFromHere.transform.position, -_shootRayFromHere.transform.right);
        //
        //         Debug.DrawRay(_shootRayFromHere.transform.position, -_shootRayFromHere.transform.right * 2f, Color.blue);
        //
        //         if (Physics.Raycast(ray2, out hit2, maxDistance: 2f))
        //         {
        //             if (hit2.transform.gameObject.GetComponent<Obstacle>())
        //             {
        //                 Destroy(hit2.transform.gameObject);
        //                 Instantiate(_obstaclePrefab, hit2.transform.position, hit2.transform.rotation);
        //                 return;
        //             }
        //
        //             if (hit2.transform.gameObject.GetComponent<TruePath>())
        //             {
        //                 Destroy(hit2.transform.gameObject);
        //                 Instantiate(_truePathPrefab, hit2.transform.position, hit2.transform.rotation);
        //                 return;
        //             }
        //         }
    }
}
    
