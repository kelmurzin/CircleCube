using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Level
{
    [System.Serializable]
    public class LevelAction
    {       
        public GameObject shapePrefab;        
        public int Scale;        
        public Transform spawn;
    }

    [System.Serializable]
    public class Level
    {
        public string name;
        public List<LevelAction> actions;
    }

    public class LevelGame : MonoBehaviour
    {              
        public List<Level> Level;        
        public List<Shapes> shape = new List<Shapes>();
        public UnityEvent LevelNext = new UnityEvent();

        private int index;
        private Level wave = new Level();
        private LevelAction waveAction = new LevelAction();


        public void SpawnShape(int index)
        {
            wave = Level[index];
            {
                foreach (LevelAction A in wave.actions)
                {
                    {

                        GameObject randomshape = Instantiate(A.shapePrefab, A.spawn.position, Quaternion.identity);
                        Shapes shapes = randomshape.GetComponent<Shapes>();
                        shapes.scale = A.Scale;

                    }
                }

            }

        }
        
        public void NextLvl()
        {
            if (index < (Level.Count - 1))
            {                
                LevelNext?.Invoke();
                Invoke("LvlInit", 1f);
            }

        }

        private void LvlInit()
        {
            {
                index++;
                SpawnShape(index);
            }
        }
    }
}