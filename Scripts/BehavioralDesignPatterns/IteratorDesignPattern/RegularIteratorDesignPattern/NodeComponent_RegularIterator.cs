namespace VisualStudio_DesignPatternsInCSharp.Scripts.BehavioralDesignPatterns.IteratorDesignPattern.RegularIteratorDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public sealed class NodeComponent<Template1> where Template1 : class
    {
        public Template1 NodeComponentValue { get; private set; }

        public NodeComponent<Template1> NodeComponentParent { get; private set; }

        public NodeComponent<Template1> NodeComponentLeft { get; private set; }

        public NodeComponent<Template1> NodeComponentRight { get; private set; }

        private NodeComponent() : base()
        {

        }

        public NodeComponent(in Template1 nodeComponentValue) : base()
        {
            NodeComponentValue = nodeComponentValue;

            NodeComponentParent = null;

            NodeComponentLeft = null;

            NodeComponentRight = null;
        }

        public NodeComponent(in Template1 nodeComponentValue, in NodeComponent<Template1> nodeComponentLeft, in NodeComponent<Template1> nodeComponentRight) : base()
        {
            NodeComponentValue = nodeComponentValue;

            NodeComponentParent = null;

            NodeComponentLeft = nodeComponentLeft;

            NodeComponentRight = nodeComponentRight;

            if (NodeComponentLeft is not null && NodeComponentLeft.NodeComponentParent is null)
            {
                NodeComponentLeft.NodeComponentParent = this;
            }

            if (NodeComponentRight is not null && NodeComponentRight.NodeComponentParent is null)
            {
                NodeComponentRight.NodeComponentParent = this;
            }
        }

        public bool CheckNodeComponentLeftIsNotNull(out NodeComponent<Template1> nodeComponentLeft)
        {
            nodeComponentLeft = NodeComponentLeft;

            return nodeComponentLeft is not null;
        }

        public bool CheckNodeComponentRightIsNotNull(out NodeComponent<Template1> nodeComponentRight)
        {
            nodeComponentRight = NodeComponentRight;

            return nodeComponentRight is not null;
        }

        public override bool Equals(object uncastedNodeComponent)
        {
            if (ReferenceEquals(objA: this, objB: uncastedNodeComponent))
            {
                return true;
            }

            if (uncastedNodeComponent is null || uncastedNodeComponent.GetType() != typeof(NodeComponent<Template1>))
            {
                return false;
            }

            if (uncastedNodeComponent is not NodeComponent<Template1> castedNodeComponent)
            {
                return false;
            }

            if (!EqualityComparer<Template1>.Default.Equals(x: NodeComponentValue, y: castedNodeComponent.NodeComponentValue))
            {
                return false;
            }

            if (!EqualityComparer<NodeComponent<Template1>>.Default.Equals(x: NodeComponentParent, y: castedNodeComponent.NodeComponentParent))
            {
                return false;
            }

            if (!EqualityComparer<NodeComponent<Template1>>.Default.Equals(x: NodeComponentLeft, y: castedNodeComponent.NodeComponentLeft))
            {
                return false;
            }

            if (!EqualityComparer<NodeComponent<Template1>>.Default.Equals(x: NodeComponentRight, y: castedNodeComponent.NodeComponentRight))
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            const int NodeComponentHashCodeInitialPrime = 0B1001111;
            const int NodeComponentHashCodeMultiplierPrime = 0B1100001;

            int NodeComponentHashCode = NodeComponentHashCodeInitialPrime;

            NodeComponentHashCode = HashCode.Combine(value1: NodeComponentHashCodeMultiplierPrime ^ NodeComponentHashCode, value2: NodeComponentValue);

            NodeComponentHashCode = HashCode.Combine(value1: NodeComponentHashCodeMultiplierPrime ^ NodeComponentHashCode, value2: NodeComponentParent);

            NodeComponentHashCode = HashCode.Combine(value1: NodeComponentHashCodeMultiplierPrime ^ NodeComponentHashCode, value2: NodeComponentLeft);

            NodeComponentHashCode = HashCode.Combine(value1: NodeComponentHashCodeMultiplierPrime ^ NodeComponentHashCode, value2: NodeComponentRight);

            return NodeComponentHashCode;
        }

        public override string ToString()
        {
            StringBuilder nodeComponentStringBuilder = new();

            nodeComponentStringBuilder.Append(value: $"[START]{nameof(NodeComponent<Template1>)}[START]");
            nodeComponentStringBuilder.AppendLine(value: string.Empty);
            nodeComponentStringBuilder.Append(value: $"{NodeComponentValue}");
            nodeComponentStringBuilder.AppendLine(value: string.Empty);
            nodeComponentStringBuilder.Append(value: $"[END]{nameof(NodeComponent<Template1>)}[END]");

            return nodeComponentStringBuilder.ToString();
        }
    }
}