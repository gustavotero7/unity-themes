using System.Collections.Generic;
using System.Text;
using System;
using UnityEngine;
namespace Zios{
	public static class GUIStyleExtension{
		public static GUILayoutOption[] CreateLayout(this GUIStyle current){
			var options = new List<GUILayoutOption>();
			if(current.fixedWidth != 0){options.Add(GUILayout.Width(current.fixedWidth));}
			return options.ToArray();
		}
		public static GUIStyle Rotate90(this GUIStyle current){
			float width = current.fixedWidth;
			float height = current.fixedHeight;
			current.fixedWidth = height;
			current.fixedHeight = width;
			current.margin = RectOffsetExtension.Rotate90(current.margin);
			current.padding = RectOffsetExtension.Rotate90(current.padding);
			return current;
		}
		public static GUIStyle Border(this GUIStyle current,int value,bool asCopy=true){
			return current.Border(value,value,value,value,asCopy);
		}
		public static GUIStyle Border(this GUIStyle current,int left,int right,int top,int bottom,bool asCopy=true){
			return current.Border(new RectOffset(left,right,top,bottom),asCopy);
		}
		public static GUIStyle Border(this GUIStyle current,RectOffset offset,bool asCopy=true){
			if(asCopy){current = new GUIStyle(current);}
			current.border = offset;
			return current;
		}
		public static GUIStyle ContentOffset(this GUIStyle current,float x,float y,bool asCopy=true){
			return current.ContentOffset(new Vector2(x,y),asCopy);
		}
		public static GUIStyle ContentOffset(this GUIStyle current,Vector2 offset,bool asCopy=true){
			if(asCopy){current = new GUIStyle(current);}
			current.contentOffset = offset;
			return current;
		}
		public static GUIStyle Clipping(this GUIStyle current,TextClipping clipping,bool asCopy=true){
			if(asCopy){current = new GUIStyle(current);}
			current.clipping = clipping;
			return current;
		}
		public static GUIStyle Clipping(this GUIStyle current,string value,bool asCopy=true){
			var clipValue = value.ToLower() == "overflow" ? TextClipping.Overflow : TextClipping.Clip;
			return current.Clipping(clipValue,asCopy);
		}
		public static GUIStyle FixedWidth(this GUIStyle current,float value,bool asCopy=true){
			if(asCopy){current = new GUIStyle(current);}
			current.fixedWidth = value;
			return current;
		}
		public static GUIStyle FixedHeight(this GUIStyle current,float value,bool asCopy=true){
			if(asCopy){current = new GUIStyle(current);}
			current.fixedHeight = value;
			return current;
		}
		public static GUIStyle Margin(this GUIStyle current,int value,bool asCopy=true){
			return current.Margin(value,value,value,value,asCopy);
		}
		public static GUIStyle Margin(this GUIStyle current,int left,int right,int top,int bottom,bool asCopy=true){
			return current.Margin(new RectOffset(left,right,top,bottom),asCopy);
		}
		public static GUIStyle Margin(this GUIStyle current,RectOffset offset,bool asCopy=true){
			if(asCopy){current = new GUIStyle(current);}
			current.margin = offset;
			return current;
		}
		public static GUIStyle Padding(this GUIStyle current,int value,bool asCopy=true){
			return current.Padding(value,value,value,value,asCopy);
		}
		public static GUIStyle Padding(this GUIStyle current,int left,int right,int top,int bottom,bool asCopy=true){
			return current.Padding(new RectOffset(left,right,top,bottom),asCopy);
		}
		public static GUIStyle Padding(this GUIStyle current,RectOffset offset,bool asCopy=true){
			if(asCopy){current = new GUIStyle(current);}
			current.padding = offset;
			return current;
		}
		public static GUIStyle Overflow(this GUIStyle current,int value,bool asCopy=true){
			return current.Overflow(value,value,value,value,asCopy);
		}
		public static GUIStyle Overflow(this GUIStyle current,int left,int right,int top,int bottom,bool asCopy=true){
			return current.Overflow(new RectOffset(left,right,top,bottom),asCopy);
		}
		public static GUIStyle Overflow(this GUIStyle current,RectOffset offset,bool asCopy=true){
			if(asCopy){current = new GUIStyle(current);}
			current.overflow = offset;
			return current;
		}
		public static GUIStyle RichText(this GUIStyle current,bool value,bool asCopy=true){
			if(asCopy){current = new GUIStyle(current);}
			current.richText = value;
			return current;
		}
		public static GUIStyle StretchHeight(this GUIStyle current,bool value,bool asCopy=true){
			if(asCopy){current = new GUIStyle(current);}
			current.stretchHeight = value;
			return current;
		}
		public static GUIStyle StretchWidth(this GUIStyle current,bool value,bool asCopy=true){
			if(asCopy){current = new GUIStyle(current);}
			current.stretchWidth = value;
			return current;
		}
		public static GUIStyle Alignment(this GUIStyle current,TextAnchor anchor,bool asCopy=true){
			if(asCopy){current = new GUIStyle(current);}
			current.alignment = anchor;
			return current;
		}
		public static GUIStyle Alignment(this GUIStyle current,string value,bool asCopy=true){
			value = value.ToLower();
			TextAnchor anchor = current.alignment;
			if(value == "upperleft"){anchor = TextAnchor.UpperLeft;}
			if(value == "uppercenter"){anchor = TextAnchor.UpperCenter;}
			if(value == "upperright"){anchor = TextAnchor.UpperRight;}
			if(value == "middleleft"){anchor = TextAnchor.MiddleLeft;}
			if(value == "middlecenter"){anchor = TextAnchor.MiddleCenter;}
			if(value == "middleright"){anchor = TextAnchor.MiddleRight;}
			if(value == "lowerleft"){anchor = TextAnchor.LowerLeft;}
			if(value == "lowercenter"){anchor = TextAnchor.LowerCenter;}
			if(value == "lowerright"){anchor = TextAnchor.LowerRight;}
			return current.Alignment(anchor,asCopy);
		}
		public static GUIStyle Font(this GUIStyle current,Font font,bool asCopy=true){
			if(asCopy){current = new GUIStyle(current);}
			current.font = font;
			return current;
		}
		public static GUIStyle Font(this GUIStyle current,string value,bool asCopy=true){
			Font font = FileManager.GetAsset<Font>(value);
			if(font != null){return current.Font(font,asCopy);}
			return current;
		}
		public static GUIStyle FontSize(this GUIStyle current,int value,bool asCopy=true){
			if(asCopy){current = new GUIStyle(current);}
			current.fontSize = value;
			return current;
		}
		public static GUIStyle FontStyle(this GUIStyle current,FontStyle fontStyle,bool asCopy=true){
			if(asCopy){current = new GUIStyle(current);}
			current.fontStyle = fontStyle;
			return current;
		}
		public static GUIStyle FontStyle(this GUIStyle current,string value,bool asCopy=true){
			value = value.ToLower();
			var fontStyle = current.fontStyle;
			if(value == "normal"){fontStyle = UnityEngine.FontStyle.Normal;}
			if(value == "bold"){fontStyle = UnityEngine.FontStyle.Bold;}
			if(value == "italic"){fontStyle = UnityEngine.FontStyle.Italic;}
			if(value == "boldanditalic"){fontStyle = UnityEngine.FontStyle.BoldAndItalic;}
			return current.FontStyle(fontStyle,asCopy);
		}
		public static GUIStyle ImagePosition(this GUIStyle current,ImagePosition imagePosition,bool asCopy=true){
			if(asCopy){current = new GUIStyle(current);}
			current.imagePosition = imagePosition;
			return current;
		}
		public static GUIStyle Background(this GUIStyle current,Texture2D background,bool asCopy=true){
			if(asCopy){current = new GUIStyle(current);}
			current.normal.background = background;
			return current;
		}
		public static GUIStyle Background(this GUIStyle current,string value,bool asCopy=true){
			if(value.IsEmpty()){return current.Background(default(Texture2D),asCopy);}
			Texture2D texture = FileManager.GetAsset<Texture2D>(value);
			if(texture != null){return current.Background(texture,asCopy);}
			return current;
		}
		public static GUIStyle TextColor(this GUIStyle current,Color textColor,bool asCopy=true){
			if(asCopy){current = new GUIStyle(current);}
			current.normal.textColor = textColor;
			return current;
		}
		public static GUIStyle TextColor(this GUIStyle current,string value,bool asCopy=true){
			return current.TextColor(Colors.FromHex(value),asCopy);
		}
		public static GUIStyle ImagePosition(this GUIStyle current,string value,bool asCopy=true){
			value = value.ToLower();
			ImagePosition imagePosition = current.imagePosition;
			if(value.ContainsAny("imageleft","left")){imagePosition = UnityEngine.ImagePosition.ImageLeft;}
			if(value.ContainsAny("imageabove","above")){imagePosition = UnityEngine.ImagePosition.ImageAbove;}
			if(value.ContainsAny("imageonly")){imagePosition = UnityEngine.ImagePosition.ImageOnly;}
			if(value.ContainsAny("textOnly")){imagePosition = UnityEngine.ImagePosition.TextOnly;}
			return current.ImagePosition(imagePosition,asCopy);
		}
		public static GUIStyle WordWrap(this GUIStyle current,bool value,bool asCopy=true){
			if(asCopy){current = new GUIStyle(current);}
			current.wordWrap = value;
			return current;
		}
		public static GUIStyleState[] GetStates(this GUIStyle current,bool offStates=true,bool onStates=true){
			var states = new List<GUIStyleState>();
			if(offStates){
				states.Add(current.normal);
				states.Add(current.hover);
				states.Add(current.active);
				states.Add(current.focused);
			}
			if(onStates){
				states.Add(current.onNormal);
				states.Add(current.onHover);
				states.Add(current.onActive);
				states.Add(current.onFocused);
			}
			return states.ToArray();
		}
		public static GUIStyle Rename(this GUIStyle current,string name){
			current.name = name;
			return current;
		}
		public static GUIStyle Use(this GUIStyle current,GUIStyle other){
			if(other.IsNull()){return current;}
			current.normal = other.normal;
			current.hover = other.hover;
			current.focused = other.focused;
			current.active = other.active;
			current.onNormal = other.onNormal;
			current.onHover = other.onHover;
			current.onFocused = other.onFocused;
			current.onActive = other.onActive;
			current.border = other.border;
			current.margin = other.margin;
			current.padding = other.padding;
			current.overflow = other.overflow;
			current.font = other.font;
			current.fontSize = other.fontSize;
			current.fontStyle = other.fontStyle;
			current.alignment = other.alignment;
			current.wordWrap = other.wordWrap;
			current.richText = other.richText;
			current.clipping = other.clipping;
			current.imagePosition = other.imagePosition;
			current.contentOffset = other.contentOffset;
			current.fixedWidth = other.fixedWidth;
			current.fixedHeight = other.fixedHeight;
			current.stretchWidth = other.stretchWidth;
			current.stretchHeight = other.stretchHeight;
			return current;
		}
	}
}