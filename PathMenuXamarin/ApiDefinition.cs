using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace PathMenuXamarin
{
	// @protocol DCPathItemButtonDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface DCPathItemButtonDelegate
	{
		// @required -(void)itemButtonTapped:(DCPathItemButton *)itemButton;
		[Abstract]
		[Export("itemButtonTapped:")]
		void ItemButtonTapped(DCPathItemButton itemButton);
	}

	// @interface DCPathItemButton : UIButton
	[BaseType(typeof(UIButton))]
	interface DCPathItemButton
	{
		// @property (assign, nonatomic) NSUInteger index;
		[Export("index")]
		nuint Index { get; set; }

		[Wrap("WeakDelegate")]
		DCPathItemButtonDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<DCPathItemButtonDelegate> delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(instancetype)initWithImage:(UIImage *)image highlightedImage:(UIImage *)highlightedImage backgroundImage:(UIImage *)backgroundImage backgroundHighlightedImage:(UIImage *)backgroundHighlightedImage;
		[Export("initWithImage:highlightedImage:backgroundImage:backgroundHighlightedImage:")]
		IntPtr Constructor(UIImage image, UIImage highlightedImage, UIImage backgroundImage, UIImage backgroundHighlightedImage);
	}

	// @protocol DCPathButtonDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface DCPathButtonDelegate
	{
		// @required -(void)pathButton:(DCPathButton *)dcPathButton clickItemButtonAtIndex:(NSUInteger)itemButtonIndex;
		[Abstract]
		[Export("pathButton:clickItemButtonAtIndex:")]
		void PathButton(DCPathButton dcPathButton, nuint itemButtonIndex);

		// @optional -(void)willPresentDCPathButtonItems:(DCPathButton *)dcPathButton;
		[Export("willPresentDCPathButtonItems:")]
		void WillPresentDCPathButtonItems(DCPathButton dcPathButton);

		// @optional -(void)didPresentDCPathButtonItems:(DCPathButton *)dcPathButton;
		[Export("didPresentDCPathButtonItems:")]
		void DidPresentDCPathButtonItems(DCPathButton dcPathButton);

		// @optional -(void)willDismissDCPathButtonItems:(DCPathButton *)dcPathButton;
		[Export("willDismissDCPathButtonItems:")]
		void WillDismissDCPathButtonItems(DCPathButton dcPathButton);

		// @optional -(void)didDismissDCPathButtonItems:(DCPathButton *)dcPathButton;
		[Export("didDismissDCPathButtonItems:")]
		void DidDismissDCPathButtonItems(DCPathButton dcPathButton);
	}

	// @interface DCPathButton : UIView <UIGestureRecognizerDelegate>
	[BaseType(typeof(UIView))]
	interface DCPathButton : IUIGestureRecognizerDelegate
	{
		[Wrap("WeakDelegate")]
		DCPathButtonDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<DCPathButtonDelegate> delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (assign, nonatomic) NSTimeInterval basicDuration;
		[Export("basicDuration")]
		double BasicDuration { get; set; }

		// @property (assign, nonatomic) BOOL allowSubItemRotation;
		[Export("allowSubItemRotation")]
		bool AllowSubItemRotation { get; set; }

		// @property (assign, nonatomic) CGFloat bloomRadius;
		[Export("bloomRadius")]
		nfloat BloomRadius { get; set; }

		// @property (assign, nonatomic) CGFloat bloomAngel;
		[Export("bloomAngel")]
		nfloat BloomAngel { get; set; }

		// @property (assign, nonatomic) CGPoint dcButtonCenter;
		[Export("dcButtonCenter", ArgumentSemantic.Assign)]
		CGPoint DcButtonCenter { get; set; }

		// @property (assign, nonatomic) BOOL allowSounds;
		[Export("allowSounds")]
		bool AllowSounds { get; set; }

		// @property (copy, nonatomic) NSString * bloomSoundPath;
		[Export("bloomSoundPath")]
		string BloomSoundPath { get; set; }

		// @property (copy, nonatomic) NSString * foldSoundPath;
		[Export("foldSoundPath")]
		string FoldSoundPath { get; set; }

		// @property (copy, nonatomic) NSString * itemSoundPath;
		[Export("itemSoundPath")]
		string ItemSoundPath { get; set; }

		// @property (assign, nonatomic) BOOL allowCenterButtonRotation;
		[Export("allowCenterButtonRotation")]
		bool AllowCenterButtonRotation { get; set; }

		// @property (nonatomic, strong) UIColor * bottomViewColor;
		[Export("bottomViewColor", ArgumentSemantic.Strong)]
		UIColor BottomViewColor { get; set; }

		// @property (assign, nonatomic) kDCPathButtonBloomDirection bloomDirection;
		[Export("bloomDirection", ArgumentSemantic.Assign)]
		kDCPathButtonBloomDirection BloomDirection { get; set; }

		// -(instancetype)initWithCenterImage:(UIImage *)centerImage highlightedImage:(UIImage *)centerHighlightedImage;
		[Export("initWithCenterImage:highlightedImage:")]
		IntPtr Constructor(UIImage centerImage, UIImage centerHighlightedImage);

		// -(instancetype)initWithButtonFrame:(CGRect)centerButtonFrame centerImage:(UIImage *)centerImage highlightedImage:(UIImage *)centerHighlightedImage;
		[Export("initWithButtonFrame:centerImage:highlightedImage:")]
		IntPtr Constructor(CGRect centerButtonFrame, UIImage centerImage, UIImage centerHighlightedImage);

		// -(void)addPathItems:(NSArray *)pathItemButtons;
		[Export("addPathItems:")]
		//[Verify(StronglyTypedNSArray)]
		void AddPathItems(NSObject[] pathItemButtons);
	}

}

