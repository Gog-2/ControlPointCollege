using System.Collections.Generic;
using UnityEngine;

public class BubbleSort : MonoBehaviour
{
   [SerializeField] private List<GameObject> _bubbleSort;
   [SerializeField] private float _spacing = 0.5f;
   
   public void SortBubbleButton()
   {
      SortBubble();
   }

   private void SortBubble()
   {
      bool swapped;
      int i, j;
      for (i = 0; i < _bubbleSort.Count - 1; i++) 
      {
         swapped = false;
         for (j = 0; j < _bubbleSort.Count - i - 1; j++) 
         {
            float currentSize = GetCubeSize(_bubbleSort[j]);
            float nextSize = GetCubeSize(_bubbleSort[j + 1]);
            if (currentSize < nextSize) 
            {
               GameObject temp = _bubbleSort[j];
               _bubbleSort[j] = _bubbleSort[j + 1];
               _bubbleSort[j + 1] = temp;
               swapped = true;
            }
         }
         if (swapped == false)
            break;
      }
      float totalWidth = 0f;
      for (i = 0; i < _bubbleSort.Count; i++)
      {
         totalWidth += _bubbleSort[i].transform.localScale.x;
         if (i < _bubbleSort.Count - 1)
            totalWidth += _spacing;
      }
      float startX = -totalWidth / 2f;
      float currentX = startX;
      for (i = 0; i < _bubbleSort.Count; i++)
      {
         float cubeHalfWidth = _bubbleSort[i].transform.localScale.x / 2f;
         Vector3 newPosition = new Vector3(currentX + cubeHalfWidth, 0f, 0f);
         _bubbleSort[i].transform.position = newPosition;
         currentX += _bubbleSort[i].transform.localScale.x + _spacing;
      }
   }
   private float GetCubeSize(GameObject cube)
   {
      Vector3 scale = cube.transform.localScale;
      return scale.x * scale.y * scale.z;
   }
}
