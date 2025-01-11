namespace VisualStudio_DesignPatternsInCSharp.BehavioralDesignPatterns.IteratorDesignPattern.RegularIteratorDesignPattern
{
    using System.Collections.Generic;

    public sealed class NodeIteratorWithRegularIterator<TTemplateComponentWithRegularIterator>(in NodeComponentWithRegularIterator<TTemplateComponentWithRegularIterator> newNodeIteratorRootNodeComponentToInitialize) : object()
    {
        private NodeComponentWithRegularIterator<TTemplateComponentWithRegularIterator> NodeIteratorRootNodeComponent { get; set; } = newNodeIteratorRootNodeComponentToInitialize;

        public IEnumerable<NodeComponentWithRegularIterator<TTemplateComponentWithRegularIterator>> GetNodeIteratorPreOrderCollection()
        {
            static IEnumerable<NodeComponentWithRegularIterator<TTemplateComponentWithRegularIterator>> GetNodeIteratorPreOrderCollectionUsing(NodeComponentWithRegularIterator<TTemplateComponentWithRegularIterator> nodeIteratorCurrentNodeComponent)
            {
                yield return nodeIteratorCurrentNodeComponent;

                if (nodeIteratorCurrentNodeComponent.NodeComponentLeftNodeComponent != null)
                {
                    foreach (NodeComponentWithRegularIterator<TTemplateComponentWithRegularIterator> nodeIteratorCurrentNodeComponentLeftNodeComponent in GetNodeIteratorPreOrderCollectionUsing(nodeIteratorCurrentNodeComponent: nodeIteratorCurrentNodeComponent.NodeComponentLeftNodeComponent))
                    {
                        yield return nodeIteratorCurrentNodeComponentLeftNodeComponent;
                    }
                }

                if (nodeIteratorCurrentNodeComponent.NodeComponentRightNodeComponent != null)
                {
                    foreach (NodeComponentWithRegularIterator<TTemplateComponentWithRegularIterator> nodeIteratorCurrentNodeComponentRightNodeComponent in GetNodeIteratorPreOrderCollectionUsing(nodeIteratorCurrentNodeComponent: nodeIteratorCurrentNodeComponent.NodeComponentRightNodeComponent))
                    {
                        yield return nodeIteratorCurrentNodeComponentRightNodeComponent;
                    }
                }
            }

            foreach (NodeComponentWithRegularIterator<TTemplateComponentWithRegularIterator> nodeIteratorChildNodeComponent in GetNodeIteratorPreOrderCollectionUsing(nodeIteratorCurrentNodeComponent: NodeIteratorRootNodeComponent))
            {
                yield return nodeIteratorChildNodeComponent;
            }
        }

        public IEnumerable<NodeComponentWithRegularIterator<TTemplateComponentWithRegularIterator>> GetNodeIteratorInOrderCollection()
        {
            static IEnumerable<NodeComponentWithRegularIterator<TTemplateComponentWithRegularIterator>> GetNodeIteratorInOrderCollectionUsing(NodeComponentWithRegularIterator<TTemplateComponentWithRegularIterator> nodeIteratorCurrentNodeComponent)
            {
                if (nodeIteratorCurrentNodeComponent.NodeComponentLeftNodeComponent != null)
                {
                    foreach (NodeComponentWithRegularIterator<TTemplateComponentWithRegularIterator> nodeIteratorCurrentNodeComponentLeftNodeComponent in GetNodeIteratorInOrderCollectionUsing(nodeIteratorCurrentNodeComponent: nodeIteratorCurrentNodeComponent.NodeComponentLeftNodeComponent))
                    {
                        yield return nodeIteratorCurrentNodeComponentLeftNodeComponent;
                    }
                }

                yield return nodeIteratorCurrentNodeComponent;

                if (nodeIteratorCurrentNodeComponent.NodeComponentRightNodeComponent != null)
                {
                    foreach (NodeComponentWithRegularIterator<TTemplateComponentWithRegularIterator> nodeIteratorCurrentNodeComponentRightNodeComponent in GetNodeIteratorInOrderCollectionUsing(nodeIteratorCurrentNodeComponent: nodeIteratorCurrentNodeComponent.NodeComponentRightNodeComponent))
                    {
                        yield return nodeIteratorCurrentNodeComponentRightNodeComponent;
                    }
                }
            }

            foreach (NodeComponentWithRegularIterator<TTemplateComponentWithRegularIterator> nodeIteratorChildNodeComponent in GetNodeIteratorInOrderCollectionUsing(nodeIteratorCurrentNodeComponent: NodeIteratorRootNodeComponent))
            {
                yield return nodeIteratorChildNodeComponent;
            }
        }

        public IEnumerable<NodeComponentWithRegularIterator<TTemplateComponentWithRegularIterator>> GetNodeIteratorPostOrderCollection()
        {
            static IEnumerable<NodeComponentWithRegularIterator<TTemplateComponentWithRegularIterator>> GetNodeIteratorPostOrderCollectionUsing(NodeComponentWithRegularIterator<TTemplateComponentWithRegularIterator> nodeIteratorCurrentNodeComponent)
            {
                if (nodeIteratorCurrentNodeComponent.NodeComponentLeftNodeComponent != null)
                {
                    foreach (NodeComponentWithRegularIterator<TTemplateComponentWithRegularIterator> nodeIteratorCurrentNodeComponentLeftNodeComponent in GetNodeIteratorPostOrderCollectionUsing(nodeIteratorCurrentNodeComponent: nodeIteratorCurrentNodeComponent.NodeComponentLeftNodeComponent))
                    {
                        yield return nodeIteratorCurrentNodeComponentLeftNodeComponent;
                    }
                }

                if (nodeIteratorCurrentNodeComponent.NodeComponentRightNodeComponent != null)
                {
                    foreach (NodeComponentWithRegularIterator<TTemplateComponentWithRegularIterator> nodeIteratorCurrentNodeComponentRightNodeComponent in GetNodeIteratorPostOrderCollectionUsing(nodeIteratorCurrentNodeComponent: nodeIteratorCurrentNodeComponent.NodeComponentRightNodeComponent))
                    {
                        yield return nodeIteratorCurrentNodeComponentRightNodeComponent;
                    }
                }

                yield return nodeIteratorCurrentNodeComponent;
            }

            foreach (NodeComponentWithRegularIterator<TTemplateComponentWithRegularIterator> nodeIteratorChildNodeComponent in GetNodeIteratorPostOrderCollectionUsing(nodeIteratorCurrentNodeComponent: NodeIteratorRootNodeComponent))
            {
                yield return nodeIteratorChildNodeComponent;
            }
        }
    }
}