namespace VisualStudio_DesignPatternsInCSharp.BehavioralDesignPatterns.IteratorDesignPattern.RegularIteratorDesignPattern
{
    using System.Collections.Generic;

    public sealed class NodeIteratorWithRegularIterator<TTemplateComponentWithRegularIterator>(in NodeComponentWithRegularIterator<TTemplateComponentWithRegularIterator> otherNodeIteratorRootNodeComponentToHandle) : object()
    {
        private NodeComponentWithRegularIterator<TTemplateComponentWithRegularIterator> NodeIteratorRootNodeComponent { get; } = otherNodeIteratorRootNodeComponentToHandle;

        public IEnumerable<NodeComponentWithRegularIterator<TTemplateComponentWithRegularIterator>> GetNodeIteratorPreOrderCollection()
        {
            static IEnumerable<NodeComponentWithRegularIterator<TTemplateComponentWithRegularIterator>> GetNodeIteratorPreOrderCollectionUsing(NodeComponentWithRegularIterator<TTemplateComponentWithRegularIterator> otherNodeIteratorCurrentNodeComponentToHandle)
            {
                yield return otherNodeIteratorCurrentNodeComponentToHandle;

                if (otherNodeIteratorCurrentNodeComponentToHandle.NodeComponentLeftNodeComponent != null)
                {
                    foreach (NodeComponentWithRegularIterator<TTemplateComponentWithRegularIterator> nodeIteratorCurrentNodeComponentLeftNodeComponent in GetNodeIteratorPreOrderCollectionUsing(otherNodeIteratorCurrentNodeComponentToHandle: otherNodeIteratorCurrentNodeComponentToHandle.NodeComponentLeftNodeComponent))
                    {
                        yield return nodeIteratorCurrentNodeComponentLeftNodeComponent;
                    }
                }

                if (otherNodeIteratorCurrentNodeComponentToHandle.NodeComponentRightNodeComponent != null)
                {
                    foreach (NodeComponentWithRegularIterator<TTemplateComponentWithRegularIterator> nodeIteratorCurrentNodeComponentRightNodeComponent in GetNodeIteratorPreOrderCollectionUsing(otherNodeIteratorCurrentNodeComponentToHandle: otherNodeIteratorCurrentNodeComponentToHandle.NodeComponentRightNodeComponent))
                    {
                        yield return nodeIteratorCurrentNodeComponentRightNodeComponent;
                    }
                }
            }

            foreach (NodeComponentWithRegularIterator<TTemplateComponentWithRegularIterator> nodeIteratorChildNodeComponent in GetNodeIteratorPreOrderCollectionUsing(otherNodeIteratorCurrentNodeComponentToHandle: NodeIteratorRootNodeComponent))
            {
                yield return nodeIteratorChildNodeComponent;
            }
        }

        public IEnumerable<NodeComponentWithRegularIterator<TTemplateComponentWithRegularIterator>> GetNodeIteratorInOrderCollection()
        {
            static IEnumerable<NodeComponentWithRegularIterator<TTemplateComponentWithRegularIterator>> GetNodeIteratorInOrderCollectionUsing(NodeComponentWithRegularIterator<TTemplateComponentWithRegularIterator> otherNodeIteratorCurrentNodeComponentToHandle)
            {
                if (otherNodeIteratorCurrentNodeComponentToHandle.NodeComponentLeftNodeComponent != null)
                {
                    foreach (NodeComponentWithRegularIterator<TTemplateComponentWithRegularIterator> nodeIteratorCurrentNodeComponentLeftNodeComponent in GetNodeIteratorInOrderCollectionUsing(otherNodeIteratorCurrentNodeComponentToHandle: otherNodeIteratorCurrentNodeComponentToHandle.NodeComponentLeftNodeComponent))
                    {
                        yield return nodeIteratorCurrentNodeComponentLeftNodeComponent;
                    }
                }

                yield return otherNodeIteratorCurrentNodeComponentToHandle;

                if (otherNodeIteratorCurrentNodeComponentToHandle.NodeComponentRightNodeComponent != null)
                {
                    foreach (NodeComponentWithRegularIterator<TTemplateComponentWithRegularIterator> nodeIteratorCurrentNodeComponentRightNodeComponent in GetNodeIteratorInOrderCollectionUsing(otherNodeIteratorCurrentNodeComponentToHandle: otherNodeIteratorCurrentNodeComponentToHandle.NodeComponentRightNodeComponent))
                    {
                        yield return nodeIteratorCurrentNodeComponentRightNodeComponent;
                    }
                }
            }

            foreach (NodeComponentWithRegularIterator<TTemplateComponentWithRegularIterator> nodeIteratorChildNodeComponent in GetNodeIteratorInOrderCollectionUsing(otherNodeIteratorCurrentNodeComponentToHandle: NodeIteratorRootNodeComponent))
            {
                yield return nodeIteratorChildNodeComponent;
            }
        }

        public IEnumerable<NodeComponentWithRegularIterator<TTemplateComponentWithRegularIterator>> GetNodeIteratorPostOrderCollection()
        {
            static IEnumerable<NodeComponentWithRegularIterator<TTemplateComponentWithRegularIterator>> GetNodeIteratorPostOrderCollectionUsing(NodeComponentWithRegularIterator<TTemplateComponentWithRegularIterator> otherNodeIteratorCurrentNodeComponentToHandle)
            {
                if (otherNodeIteratorCurrentNodeComponentToHandle.NodeComponentLeftNodeComponent != null)
                {
                    foreach (NodeComponentWithRegularIterator<TTemplateComponentWithRegularIterator> nodeIteratorCurrentNodeComponentLeftNodeComponent in GetNodeIteratorPostOrderCollectionUsing(otherNodeIteratorCurrentNodeComponentToHandle: otherNodeIteratorCurrentNodeComponentToHandle.NodeComponentLeftNodeComponent))
                    {
                        yield return nodeIteratorCurrentNodeComponentLeftNodeComponent;
                    }
                }

                if (otherNodeIteratorCurrentNodeComponentToHandle.NodeComponentRightNodeComponent != null)
                {
                    foreach (NodeComponentWithRegularIterator<TTemplateComponentWithRegularIterator> nodeIteratorCurrentNodeComponentRightNodeComponent in GetNodeIteratorPostOrderCollectionUsing(otherNodeIteratorCurrentNodeComponentToHandle: otherNodeIteratorCurrentNodeComponentToHandle.NodeComponentRightNodeComponent))
                    {
                        yield return nodeIteratorCurrentNodeComponentRightNodeComponent;
                    }
                }

                yield return otherNodeIteratorCurrentNodeComponentToHandle;
            }

            foreach (NodeComponentWithRegularIterator<TTemplateComponentWithRegularIterator> nodeIteratorChildNodeComponent in GetNodeIteratorPostOrderCollectionUsing(otherNodeIteratorCurrentNodeComponentToHandle: NodeIteratorRootNodeComponent))
            {
                yield return nodeIteratorChildNodeComponent;
            }
        }
    }
}