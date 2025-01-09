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

        public NodeComponentWithRegularIterator(in TTemplateComponentWithRegularIterator newNodeComponentValueToInitialize)
        {
            NodeComponentValue = newNodeComponentValueToInitialize;

            NodeComponentParentNodeComponent = null;

            NodeComponentLeftNodeComponent = null;
            NodeComponentRightNodeComponent = null;
        }

        public NodeComponentWithRegularIterator(in TTemplateComponentWithRegularIterator newNodeComponentValueToInitialize, in NodeComponentWithRegularIterator<TTemplateComponentWithRegularIterator> newNodeComponentLeftNodeComponentToInitialize, in NodeComponentWithRegularIterator<TTemplateComponentWithRegularIterator> newNodeComponentRightNodeComponentToInitialize) : base()
        {
            NodeComponentValue = newNodeComponentValueToInitialize;

            NodeComponentParentNodeComponent = null;

            NodeComponentLeftNodeComponent = newNodeComponentLeftNodeComponentToInitialize;
            NodeComponentRightNodeComponent = newNodeComponentRightNodeComponentToInitialize;

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
            Console.WriteLine(value: GetNodeComponentContentUsing(specificNodeComponentToHandle: this));
        }

        private StringBuilder GetNodeComponentContent()
        {
            StringBuilder nodeComponentContentStringBuilder = new StringBuilder();

            nodeComponentContentStringBuilder.Append(value: $"{NodeComponentValue.ToString().ToUpperInvariant()}".ToUpperInvariant());

            return nodeComponentContentStringBuilder;
        }

        private static StringBuilder GetNodeComponentContentUsing(in NodeComponentWithRegularIterator<TTemplateComponentWithRegularIterator> specificNodeComponentToHandle)
        {
            StringBuilder nodeComponentContentStringBuilder = new StringBuilder();

            nodeComponentContentStringBuilder.Append(value: specificNodeComponentToHandle.GetNodeComponentContent());

            return nodeComponentContentStringBuilder;
        }

        public override bool Equals(object specificNodeComponentUndefinedObject)
        {
            if (ReferenceEquals(objA: this, objB: specificNodeComponentUndefinedObject) == true)
            {
                return true;
            }

            if (specificNodeComponentUndefinedObject == null || specificNodeComponentUndefinedObject is NodeComponentWithRegularIterator<TTemplateComponentWithRegularIterator> specificNodeComponentDefinedObject == false)
            {
                return false;
            }

            if (NodeComponentValue.Equals(obj: specificNodeComponentDefinedObject.NodeComponentValue) == false)
            {
                return false;
            }

            if (NodeComponentParentNodeComponent.Equals(specificNodeComponentUndefinedObject: specificNodeComponentDefinedObject.NodeComponentParentNodeComponent) == false)
            {
                return false;
            }

            if (NodeComponentLeftNodeComponent.Equals(specificNodeComponentUndefinedObject: specificNodeComponentDefinedObject.NodeComponentLeftNodeComponent) == false || NodeComponentRightNodeComponent.Equals(specificNodeComponentUndefinedObject: specificNodeComponentDefinedObject.NodeComponentRightNodeComponent) == false)
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
            return GetNodeComponentContentUsing(specificNodeComponentToHandle: this).ToString().ToUpperInvariant();
        }
    }
}