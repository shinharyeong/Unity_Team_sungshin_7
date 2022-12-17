Shader "Custom/box3"
{
    Properties
    {
        _MainTex("Albedo (RGB)", 2D) = "white" {}
        _Brightness("Light", Range(-1,1)) = 0

    }
        SubShader
        {
            Tags { "RenderType" = "Opaque" }

            CGPROGRAM

            #pragma surface surf Standard 

            sampler2D _MainTex;
            float _Brightness;
            struct Input
            {
                float2 uv_MainTex;
            };



            void surf(Input IN, inout SurfaceOutputStandard o)
            {
                fixed4 c = tex2D(_MainTex, IN.uv_MainTex);

                o.Albedo = c.rgb + _Brightness;

                o.Alpha = c.a;

            }
            ENDCG
        }
            FallBack "Diffuse"
}