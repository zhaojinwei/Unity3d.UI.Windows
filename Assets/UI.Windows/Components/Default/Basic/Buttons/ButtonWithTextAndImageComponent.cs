using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.UI.Windows.Extensions;

namespace UnityEngine.UI.Windows.Components {

	public class ButtonWithTextAndImageComponent : ButtonComponent, IImageComponent, ITextComponent {

		[Header("Text (Optional)")]
		#region macros UI.Windows.TextComponent (overrideColor:override)

	/*
	 * This code is auto-generated by Macros Module
	 * Do not change anything
	 */
	[SerializeField]
			private Text text;
	
			public float GetContentHeight(string text, Vector2 containerSize) {
	
				var settings = this.text.GetGenerationSettings(containerSize);
				return this.text.cachedTextGenerator.GetPreferredHeight(text, settings);
	
			}
	
			public void SetValue(int value, UnityEngine.UI.Windows.Components.TextComponent.ValueFormat format = UnityEngine.UI.Windows.Components.TextComponent.ValueFormat.None) {
				
				this.SetText(TextComponent.FormatValue(value, format));
				
			}
	
			public void SetTextVerticalOverflow(VerticalWrapMode mode) {
				
				if (this.text != null) this.text.verticalOverflow = mode;
				
			}
			
			public void SetTextHorizontalOverflow(HorizontalWrapMode mode) {
				
				if (this.text != null) this.text.horizontalOverflow = mode;
				
			}
	
			public void SetTextAlignment(TextAnchor anchor) {
				
				if (this.text != null) this.text.alignment = anchor;
				
			}
	
			public string GetText() {
	
				return (this.text != null) ? this.text.text : string.Empty;
	
			}
	
			public void SetText(string text) {
	
				if (this.text != null) this.text.text = text;
	
			}
			
			public virtual void SetTextColor(Color color) {
				
				this.text.color = color;
				
			}
			
			public virtual Color GetTextColor() {
				
				return this.text.color;
				
			}
	#endregion
		
		[Header("Images (Optional)")]
		#region macros UI.Windows.ImageComponent (overrideColor:override)

	/*
	 * This code is auto-generated by Macros Module
	 * Do not change anything
	 */
	[Header("Properties")]
			public bool preserveAspect;
	
			[SerializeField]
			private Image image;
			
			[SerializeField]
			private RawImage rawImage;
	
			public void SetImage(Sprite sprite, bool withPivotsAndSize = false) {
	
				this.SetImage(sprite, this.preserveAspect, withPivotsAndSize);
	
			}
	
			public void SetImage(Sprite sprite, bool preserveAspect, bool withPivotsAndSize = false) {
				
				if (this.image != null) {
	
					this.image.sprite = sprite;
					this.image.preserveAspect = preserveAspect;
	
					if (withPivotsAndSize == true && sprite != null) {
	
						var rect = (this.transform as RectTransform);
	
						rect.sizeDelta = sprite.rect.size;
						rect.pivot = sprite.GetPivot();
						rect.anchoredPosition = Vector2.zero;
	
					}
	
				}
				
			}
	
			public void SetImage(Texture texture) {
	
				this.SetImage(texture, this.preserveAspect);
	
			}
	
			public void SetImage(Texture texture, bool preserveAspect) {
				
				if (this.rawImage != null) {
	
					this.rawImage.texture = texture;
					if (this.preserveAspect == true) ME.Utilities.PreserveAspect(this.rawImage);
	
				}
				
			}
			
			public override Color GetColor() {
				
				Color color = Color.white;
				if (this.image != null) {
					
					color = this.image.color;
					
				} else if (this.rawImage != null) {
					
					color = this.rawImage.color;
					
				}
	
				return color;
	
			}
	
			public override void SetColor(Color color) {
	
				if (this.image != null) {
					
					this.image.color = color;
					
				} else if (this.rawImage != null) {
					
					this.rawImage.color = color;
					
				}
	
			}
	
			public void SetAlpha(float value) {
	
				var color = this.GetColor();
				color.a = value;
				this.SetColor(color);
	
			}
	
			public void SetMaterial(Material material) {
	
				if (this.image != null) {
	
					this.image.material = material;
					this.image.SetMaterialDirty();
	
				} else if (this.rawImage != null) {
	
					this.rawImage.material = material;
					this.rawImage.SetMaterialDirty();
	
				}
	
			}
	#endregion
		
		#if UNITY_EDITOR
		public override void OnValidateEditor() {
			
			base.OnValidateEditor();

			if (this.gameObject.activeSelf == false) return;
			
			#region macros UI.Windows.Editor.TextComponent 
	/*
	 * This code is auto-generated by Macros Module
	 * Do not change anything
	 */
	var texts = this.GetComponentsInChildren<Text>(true);
				if (texts.Length == 1) this.text = texts[0];
	#endregion

			#region macros UI.Windows.Editor.ImageComponent 
	/*
	 * This code is auto-generated by Macros Module
	 * Do not change anything
	 */
	if (this.image == null) this.image = this.GetComponent<Image>();
				if (this.rawImage == null) this.rawImage = this.GetComponent<RawImage>();
	#endregion

		}
		#endif

	}

}