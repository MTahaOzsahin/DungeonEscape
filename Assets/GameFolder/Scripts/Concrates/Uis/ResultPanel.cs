using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace DungeonEscape.Concrates.Uis
{
    public class ResultPanel : MonoBehaviour
    {
        TextMeshProUGUI resultMessage;
        private void Awake()
        {
            resultMessage = transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        }
        public void SetResultMessage(string result)
        {
            resultMessage.text = result;
        }
    }
}
