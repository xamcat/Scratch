using System;
using FormsProofOfConcept.Controls;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(StickyHeaderCollectionView), typeof(CollectionViewRenderer))]
namespace FormsProofOfConcept.iOS.Renderers
{
    public class StickyHeaderCollectionViewRenderer : CollectionViewRenderer
    {
        public StickyHeaderCollectionViewRenderer()
        {
            var collectionView = NativeView as UICollectionView;
            collectionView.CollectionViewLayout = new StickyHeaderCollectionViewFlowLayout();
        }

        protected override void OnElementChanged(ElementChangedEventArgs<GroupableItemsView> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                var collectionView = NativeView as UICollectionView;
                collectionView.CollectionViewLayout = new StickyHeaderCollectionViewFlowLayout();
            }
        }
    }

    public class StickyHeaderCollectionViewFlowLayout : UICollectionViewFlowLayout
    {
        public override bool SectionHeadersPinToVisibleBounds { get => true; set => base.SectionHeadersPinToVisibleBounds = value; }
    }
}
