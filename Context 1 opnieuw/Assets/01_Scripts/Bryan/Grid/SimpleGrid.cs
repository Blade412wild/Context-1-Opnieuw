using System.Collections.Generic;
using Unity.Collections;
using Unity.VisualScripting;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

namespace _01_Scripts.Bryan.Grid
{
    public class SimpleGrid<T>
    {
        private T[,] _gridData;
        private int _width;
        private int _height;

        public void LoadGrid(int size)
        {
            _width = size;
            _height = size;

            _gridData = new T[size, size];

            // for (int x = 0; x < _gridData.GetLength(0); x++)
            // {
            //     for (int y = 0; y < _gridData.GetLength(1); y++)
            //     {
            //         _gridData[x, y] = false;
            //     }
            // }
        }

        private List<Vector2Int> GetNeighbours(int x, int y, int radius = 1)
        {
            var minRow = Mathf.Max(x - radius, 0);
            var maxRow = Mathf.Min((x + radius), _width - 1);

            var minCol = Mathf.Max(y - radius, 0);
            var maxCol = Mathf.Min(y + radius, _height - 1);

            var list = new List<Vector2Int>();

            for (var row = minRow; row <= maxRow; row++)
            {
                for (var col = minCol; col <= maxCol; col++)
                {
                    if (row == x && col == y)
                    {
                        continue;
                    }

                    list.Add(new Vector2Int(row, col));
                }
            }

            return list;
        }

        public List<int> GetNeighbours(int index)
        {
            int x = index % _width;
            int y = index / _height;
            var neighbours = GetNeighbours(x, y, 1);
            var indexes = new List<int>();

            foreach (var vector2Int in neighbours)
            {
                var newIndex = vector2Int.y * _width + vector2Int.x;
                indexes.Add(newIndex);
            }

            return indexes;
        }

        //Get the data at a specific row 
        public T GetData(int index)
        {
            int x = index % _width;
            int y = index / _height;

            /*if (x > _width - 1 || x < 0 || y > _height - 1 || y < 0)
            {
                return false;
            }*/

            return _gridData[x, y];
        }

        public void SetData(int index, T value)
        {
            int x = index % _width;
            int y = index / _height;

            _gridData[x, y] = value;
            Debug.Log($"index: {index} = {x} , {y}, width: {_width}, height: {_height}");
        }
    }
}