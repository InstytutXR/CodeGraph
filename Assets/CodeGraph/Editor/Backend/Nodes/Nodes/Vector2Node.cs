using System.Collections.Generic;

namespace Nodes {
    public class Vector2Node : Node {
        public Vector2Node() {
            Inputs = new List<InputNode> {new FloatInputNode(this), new FloatInputNode(this)};
            Outputs = new List<OutputNode> {new Vector2OutputNode(this)};
        }

        public override string GetCode(int callStackLevel) {
            return $"new Vector2({Inputs[0].OutputLocationReference.ParentNodeReference.GetCode(callStackLevel+1)}, {Inputs[1].OutputLocationReference.ParentNodeReference.GetCode(callStackLevel+1)})";
        }
    }
}