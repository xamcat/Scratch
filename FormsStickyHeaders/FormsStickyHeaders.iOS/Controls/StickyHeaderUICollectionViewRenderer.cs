using System;
using System.ComponentModel;
using System.Linq;
using FormsProofOfConcept.Controls;
using FormsProofOfConcept.iOS.Controls;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(StickyHeaderCollectionView), typeof(StickyHeaderUICollectionViewRenderer))]
namespace FormsProofOfConcept.iOS.Controls
{
    public class StickyHeaderUICollectionViewRenderer : CollectionViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<GroupableItemsView> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                var view = Control as UIView;
                var uiCollectionView = view.Subviews.FirstOrDefault(a => a is UICollectionView);
                if (uiCollectionView is UICollectionView collectionView)
                {
                    if (collectionView.CollectionViewLayout is UICollectionViewFlowLayout layout)
                    {
                        layout.SectionHeadersPinToVisibleBounds = true;
                    }
                }
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs changedProperty)
        {
            base.OnElementPropertyChanged(sender, changedProperty);
        }
    }
}
