namespace VisualStudio_DesignPatternsInCSharp.BehavioralDesignPatterns.IteratorDesignPattern.RegularIteratorDesignPattern
{
    using System;
    using System.Text;

    public sealed class NodeComponentWithRegularIterator<TTemplateComponentWithRegularIterator>
    {
        public TTemplateComponentWithRegularIterator NodeComponentValue { get; private set; }

        public NodeComponentWithRegularIterator<TTemplateComponentWithRegularIterator> NodeComponentParentNodeComponent { get; private set; }

        public NodeComponentWithRegularIterator<TTemplateComponentWithRegularIterator> NodeComponentLeftNodeComponent { get; private set; }
        public NodeComponentWithRegularIterator<TTemplateComponentWithRegularIterator> NodeComponentRightNodeComponent { get; private set; }

        public NodeComponentWithRegularIterator(in TTemplateComponentWithRegularIterator otherNodeComponentValueToHandle)
        {
            NodeComponentValue = otherNodeComponentValueToHandle;

            NodeComponentParentNodeComponent = null;

            NodeComponentLeftNodeComponent = null;
            NodeComponentRightNodeComponent = null;
        }

        public NodeComponentWithRegularIterator(in TTemplateComponentWithRegularIterator otherNodeComponentValueToHandle, in NodeComponentWithRegularIterator<TTemplateComponentWithRegularIterator> otherNodeComponentLeftNodeComponentToHandle, in NodeComponentWithRegularIterator<TTemplateComponentWithRegularIterator> otherNodeComponentRightNodeComponentToHandle) : base()
        {
            NodeComponentValue = otherNodeComponentValueToHandle;

            NodeComponentParentNodeComponent = null;

            NodeComponentLeftNodeComponent = otherNodeComponentLeftNodeComponentToHandle;
            NodeComponentRightNodeComponent = otherNodeComponentRightNodeComponentToHandle;

            if (NodeComponentLeftNodeComponent != null)
            {
                NodeComponentLeftNodeComponent.NodeComponentParentNodeComponent = this;
            }

            if (NodeComponentRightNodeComponent != null)
            {
                NodeComponentRightNodeComponent.NodeComponentParentNodeComponent = this;
            }
        }

        public void DisplayNodeComponentContent()
        {
            Console.WriteLine(value: GetNodeComponentContentUsing(otherNodeComponentToHandle: this));
        }

        private void SetNodeComponentContentValueContentUsing(StringBuilder nodeComponentContentStringBuilder)
        {
            nodeComponentContentStringBuilder.Append(value: $"{NodeComponentValue.ToString().ToUpperInvariant()}".ToUpperInvariant());
        }

        private StringBuilder GetNodeComponentContent()
        {
            StringBuilder nodeComponentContentStringBuilder = new();

            SetNodeComponentContentValueContentUsing(nodeComponentContentStringBuilder: nodeComponentContentStringBuilder);

            return nodeComponentContentStringBuilder;
        }

        private static StringBuilder GetNodeComponentContentUsing(in NodeComponentWithRegularIterator<TTemplateComponentWithRegularIterator> otherNodeComponentToHandle)
        {
            StringBuilder nodeComponentContentStringBuilder = new();

            nodeComponentContentStringBuilder.Append(value: otherNodeComponentToHandle.GetNodeComponentContent());

            return nodeComponentContentStringBuilder;
        }

        public override bool Equals(object otherNodeComponentUndefinedObjectToHandle)
        {
            if (ReferenceEquals(objA: this, objB: otherNodeComponentUndefinedObjectToHandle) == true)
            {
                return true;
            }

            if (otherNodeComponentUndefinedObjectToHandle == null || otherNodeComponentUndefinedObjectToHandle is NodeComponentWithRegularIterator<TTemplateComponentWithRegularIterator> otherNodeComponentDefinedObjectToHandle == false)
            {
                return false;
            }

            if (NodeComponentValue.Equals(obj: otherNodeComponentDefinedObjectToHandle.NodeComponentValue) == false)
            {
                return false;
            }

            if (NodeComponentParentNodeComponent.Equals(otherNodeComponentUndefinedObjectToHandle: otherNodeComponentDefinedObjectToHandle.NodeComponentParentNodeComponent) == false)
            {
                return false;
            }

            if (NodeComponentLeftNodeComponent.Equals(otherNodeComponentUndefinedObjectToHandle: otherNodeComponentDefinedObjectToHandle.NodeComponentLeftNodeComponent) == false || NodeComponentRightNodeComponent.Equals(otherNodeComponentUndefinedObjectToHandle: otherNodeComponentDefinedObjectToHandle.NodeComponentRightNodeComponent) == false)
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            const int NodeComponentHashCodeInitialPrime = 17;
            const int NodeComponentHashCodeMultiplierPrime = 23;

            int nodeComponentHashCode = NodeComponentHashCodeInitialPrime;

            nodeComponentHashCode = nodeComponentHashCode * NodeComponentHashCodeMultiplierPrime + NodeComponentValue?.GetHashCode() ?? default;

            nodeComponentHashCode = nodeComponentHashCode * NodeComponentHashCodeMultiplierPrime + NodeComponentParentNodeComponent?.GetHashCode() ?? default;

            nodeComponentHashCode = nodeComponentHashCode * NodeComponentHashCodeMultiplierPrime + NodeComponentLeftNodeComponent?.GetHashCode() ?? default;
            nodeComponentHashCode = nodeComponentHashCode * NodeComponentHashCodeMultiplierPrime + NodeComponentRightNodeComponent?.GetHashCode() ?? default;

            return nodeComponentHashCode;
        }

        public override string ToString()
        {
            return GetNodeComponentContentUsing(otherNodeComponentToHandle: this).ToString().ToUpperInvariant();
        }
    }
}