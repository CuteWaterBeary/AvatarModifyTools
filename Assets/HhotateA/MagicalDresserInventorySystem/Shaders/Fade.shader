﻿Shader "HhotateA/DimensionalStorage/Fade"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
		_Color("Color", Color) = (1.,1.,1.,1.)
		_ColorCull("ColorCull", Color) = (0.2,0.2,0.2,1.)
    	_AnimationTex ("_AnimationTex", 2D) = "white" {}
    	_AnimationTime ("_AnimationTime",range(0.,1.)) = 0.
    }
    SubShader
    {
        Tags { "RenderType"="Transparent" "Queue"="Transparent+50"}
        Cull Off
		Blend SrcAlpha OneMinusSrcAlpha

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            	float2 viewuv : TEXCOORD1;
            };

            sampler2D _MainTex;
            float4 _MainTex_ST;
            fixed4 _Color, _ColorCull;
            sampler2D _AnimationTex;
            float4 _AnimationTex_ST;
            float _AnimationTime;

            v2f vert (appdata v)
            {
            	v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);
				o.viewuv = TRANSFORM_TEX(
					calccamera(v.vertex) - calccamera(float4(0.0,0.0,0.0,1.0)) + float4(0.5,0.5,0.0,0.0) ,
					_AnimationTex);
            	return o;
            }

            fixed4 frag (v2f i,fixed facing : VFACE) : SV_Target
            {
                fixed4 col = tex2D(_MainTex, i.uv);
            	float alpha = getGray(tex2D(_AnimationTex, i.viewuv));
                col.a = saturate(2*_AnimationTime-alpha);
                return  facing > 0 ? col * _Color : col * _ColorCull;
            }
            ENDCG
			CGINCLUDE
				#include "UnityCG.cginc"
				//base on "https://qiita.com/_nabe/items/c8ba019f26d644db34a8"
				float3 rgb2hsv(float3 c) {
					float4 k = float4( 0.0, -1.0 / 3.0, 2.0 / 3.0, -1.0 );
					float e = 1.0e-10;
					float4 p = lerp( float4(c.bg, k.wz), float4(c.gb, k.xy), step(c.b, c.g) );
					float4 q = lerp( float4(p.xyw, c.r), float4(c.r, p.yzx), step(p.x, c.r) );
					float d = q.x - min(q.w, q.y);
					return float3( abs(q.z + (q.w - q.y) / (6.0 * d + e)), d / (q.x + e), q.x );
				}
				float3 hsv2rgb(float3 c) {
					float4 k = float4( 1.0, 2.0 / 3.0, 1.0 / 3.0, 3.0 );
					float3 p = abs( frac(c.xxx + k.xyz) * 6.0 - k.www );
					return c.z * lerp( k.xxx, saturate(p - k.xxx), c.y );
				}
				float3 stereocamerapos(){
				                float3 cameraPos = _WorldSpaceCameraPos;
				                #if defined(USING_STEREO_MATRICES)
				                cameraPos = (unity_StereoWorldSpaceCameraPos[0] + unity_StereoWorldSpaceCameraPos[1]) * .5;
				                #endif
				                return cameraPos;
				}

				float4 calccamera(float4 input) {
					float4 vpos = mul(UNITY_MATRIX_MV,input);
					vpos.xyz -= _WorldSpaceCameraPos;
					vpos.xyz += stereocamerapos();
					return vpos;
				}
				float getGray(float4 c)
	            {
            		return (c.r+c.g+c.b)*c.a*0.3333333333;

	            }
			ENDCG
        }
    }
}
