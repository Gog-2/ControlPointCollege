using System.Collections.Generic;
using UnityEngine;

public class BubbleSort : MonoBehaviour
{
   [SerializeField] private List<GameObject> _bubbleSort;
   public void SortBubbleButton()
   {
      SortBubble();
   }

   private void SortBubble()
   {
      bool swapped;
      int i, j;
      for (i = 0; i < _bubbleSort.Count - 1; i++) {
         swapped = false;
         for (j = 0; j < _bubbleSort.Count - i - 1; j++) {
            if (_bubbleSort[j].transform.position.x +_bubbleSort[j].transform.position.y > _bubbleSort[j + 1].transform.position.x + _bubbleSort[j + 1].transform.position.y) {
               var temp = _bubbleSort[j].transform.position;
               _bubbleSort[j].transform.position = _bubbleSort[j + 1].transform.position;
               _bubbleSort[j + 1].transform.position = temp;
               swapped = true;
            }
         }
         if (swapped == false)
            break;
      }
      for (i = 0; i < _bubbleSort.Count - 1; i++) {
         swapped = false;
         for (j = 0; j < _bubbleSort.Count - i - 1; j++) {
            if (_bubbleSort[j].transform.localScale.x +_bubbleSort[j].transform.localScale.y > _bubbleSort[j + 1].transform.localScale.x + _bubbleSort[j + 1].transform.localScale.y) {
               var temp = _bubbleSort[j].transform.localScale;
               _bubbleSort[j].transform.localScale = _bubbleSort[j + 1].transform.localScale;
               _bubbleSort[j + 1].transform.localScale = temp;
               swapped = true;
            }
         }
         if (swapped == false)
            break;
      }
   }
}
