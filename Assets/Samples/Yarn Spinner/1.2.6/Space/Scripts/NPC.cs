using UnityEngine;

namespace Yarn.Unity.Example {
    /// attached to the non-player characters, and stores the name of the Yarn
    /// node that should be run when you talk to them.

    public class NPC : MonoBehaviour {

        public string characterName = "";

        public string talkToNode = "";

        [Header("Optional")]
        public YarnProgram scriptToLoad;

        void Start () {
            if (scriptToLoad != null) {
                DialogueRunner dialogueRunner = FindObjectOfType<Yarn.Unity.DialogueRunner>();
                dialogueRunner.Add(scriptToLoad);                
            }
        }
    }

}
