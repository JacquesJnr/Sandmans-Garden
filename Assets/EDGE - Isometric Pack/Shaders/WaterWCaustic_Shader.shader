// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'

// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:1,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:8757,x:35202,y:33028,varname:node_8757,prsc:2|diff-8632-RGB,emission-1337-OUT,alpha-4368-OUT,refract-4366-OUT,voffset-4780-OUT,tess-7107-OUT;n:type:ShaderForge.SFN_Color,id:8632,x:34932,y:32530,ptovrint:False,ptlb:Color,ptin:_Color,varname:_Color,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.4779412,c2:0.7839757,c3:1,c4:1;n:type:ShaderForge.SFN_Tex2d,id:7236,x:31972,y:33413,ptovrint:False,ptlb:Noise Texture,ptin:_NoiseTexture,varname:_NoiseTexture,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:1,isnm:False|UVIN-7958-UVOUT;n:type:ShaderForge.SFN_ComponentMask,id:5916,x:32143,y:33413,varname:node_5916,prsc:2,cc1:0,cc2:0,cc3:-1,cc4:-1|IN-7236-RGB;n:type:ShaderForge.SFN_Slider,id:9479,x:31931,y:33671,ptovrint:False,ptlb:Refraction,ptin:_Refraction,varname:_Refraction,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-1,cur:0.4700855,max:1;n:type:ShaderForge.SFN_Multiply,id:4366,x:32370,y:33548,varname:node_4366,prsc:2|A-5916-OUT,B-9479-OUT;n:type:ShaderForge.SFN_Panner,id:7958,x:31720,y:33374,varname:node_7958,prsc:0,spu:0.1,spv:0.1|UVIN-6266-UVOUT,DIST-722-OUT;n:type:ShaderForge.SFN_TexCoord,id:6266,x:31514,y:33374,varname:node_6266,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Time,id:6843,x:31386,y:33519,varname:node_6843,prsc:2;n:type:ShaderForge.SFN_Multiply,id:722,x:31653,y:33613,varname:node_722,prsc:2|A-6843-T,B-6770-OUT;n:type:ShaderForge.SFN_ValueProperty,id:6770,x:31322,y:33733,ptovrint:False,ptlb:Speed,ptin:_Speed,varname:_Speed,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Time,id:194,x:30668,y:33931,varname:node_194,prsc:2;n:type:ShaderForge.SFN_FragmentPosition,id:1236,x:30845,y:34216,varname:node_1236,prsc:2;n:type:ShaderForge.SFN_Add,id:2593,x:31118,y:34234,varname:node_2593,prsc:2|A-1236-X,B-6018-OUT;n:type:ShaderForge.SFN_Sin,id:6551,x:31469,y:34234,varname:node_6551,prsc:2|IN-3009-OUT;n:type:ShaderForge.SFN_Multiply,id:1879,x:31652,y:34234,varname:node_1879,prsc:2|A-6551-OUT,B-8440-OUT;n:type:ShaderForge.SFN_ValueProperty,id:8440,x:31469,y:34409,ptovrint:False,ptlb:WaveSpread,ptin:_WaveSpread,varname:_WaveSpread,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Add,id:1237,x:31836,y:34234,varname:node_1237,prsc:2|A-1879-OUT,B-3490-OUT;n:type:ShaderForge.SFN_ValueProperty,id:3490,x:31652,y:34409,ptovrint:False,ptlb:WaveWidth,ptin:_WaveWidth,varname:_WaveWidth,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:10;n:type:ShaderForge.SFN_Multiply,id:3009,x:31301,y:34234,varname:node_3009,prsc:2|A-2593-OUT,B-7347-OUT;n:type:ShaderForge.SFN_ValueProperty,id:7347,x:31118,y:34398,ptovrint:False,ptlb:WaveCount,ptin:_WaveCount,varname:_WaveCount,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:10;n:type:ShaderForge.SFN_RemapRange,id:3351,x:32017,y:34234,varname:node_3351,prsc:2,frmn:-1,frmx:1,tomn:0,tomx:1|IN-1237-OUT;n:type:ShaderForge.SFN_Append,id:618,x:32619,y:34185,varname:node_618,prsc:2|A-6796-OUT,B-1607-OUT;n:type:ShaderForge.SFN_Append,id:4780,x:32823,y:34185,varname:node_4780,prsc:2|A-618-OUT,B-4246-OUT;n:type:ShaderForge.SFN_Vector1,id:6796,x:32420,y:34127,varname:node_6796,prsc:2,v1:0;n:type:ShaderForge.SFN_Vector1,id:4246,x:32619,y:34326,varname:node_4246,prsc:2,v1:0;n:type:ShaderForge.SFN_Multiply,id:1607,x:32420,y:34246,varname:node_1607,prsc:2|A-5729-OUT,B-3672-OUT;n:type:ShaderForge.SFN_Slider,id:3672,x:31860,y:34436,ptovrint:False,ptlb:WaveHeight,ptin:_WaveHeight,varname:_WaveHeight,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.073,max:1;n:type:ShaderForge.SFN_Multiply,id:5729,x:32239,y:34168,varname:node_5729,prsc:2|A-8349-R,B-3351-OUT;n:type:ShaderForge.SFN_TexCoord,id:7816,x:31380,y:33914,varname:node_7816,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Panner,id:216,x:31723,y:34017,varname:node_216,prsc:2,spu:0.5,spv:0.5|UVIN-7816-UVOUT;n:type:ShaderForge.SFN_Tex2d,id:8349,x:31925,y:34017,ptovrint:False,ptlb:WaveDistortionNoise,ptin:_WaveDistortionNoise,varname:_WaveDistortionNoise,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-216-UVOUT;n:type:ShaderForge.SFN_ValueProperty,id:2252,x:30682,y:34123,ptovrint:False,ptlb:WaveSpeed,ptin:_WaveSpeed,varname:_WaveSpeed,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:10;n:type:ShaderForge.SFN_Multiply,id:6018,x:30896,y:34040,varname:node_6018,prsc:2|A-194-TSL,B-2252-OUT;n:type:ShaderForge.SFN_Slider,id:7107,x:33231,y:34194,ptovrint:False,ptlb:Tessellation,ptin:_Tessellation,varname:_Tessellation,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:10;n:type:ShaderForge.SFN_Color,id:4715,x:34403,y:32776,ptovrint:False,ptlb:EmissionColor,ptin:_EmissionColor,varname:_EmissionColor,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.4779412,c2:0.7839757,c3:1,c4:1;n:type:ShaderForge.SFN_NormalVector,id:2150,x:32345,y:32979,prsc:2,pt:False;n:type:ShaderForge.SFN_Fresnel,id:6542,x:32611,y:33124,varname:node_6542,prsc:2|NRM-2150-OUT,EXP-9156-OUT;n:type:ShaderForge.SFN_Slider,id:9156,x:32254,y:33232,ptovrint:False,ptlb:Fresnel Amount,ptin:_FresnelAmount,varname:_FresnelAmount,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Slider,id:7403,x:32400,y:33373,ptovrint:False,ptlb:Intensity,ptin:_Intensity,varname:_Intensity,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Multiply,id:4368,x:32985,y:33160,varname:node_4368,prsc:2|A-6542-OUT,B-7403-OUT;n:type:ShaderForge.SFN_TexCoord,id:34,x:32874,y:32810,varname:node_34,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Panner,id:3201,x:33160,y:32716,varname:node_3201,prsc:2,spu:1,spv:1|UVIN-34-UVOUT,DIST-8639-OUT;n:type:ShaderForge.SFN_Tex2d,id:6273,x:33342,y:32716,ptovrint:False,ptlb:Noise,ptin:_Noise,varname:_Noise,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:2ca83718351fa8643a7aa175b01e42b9,ntxv:0,isnm:True|UVIN-3201-UVOUT;n:type:ShaderForge.SFN_RemapRange,id:4289,x:33509,y:32716,varname:node_4289,prsc:2,frmn:0,frmx:1,tomn:0,tomx:0.1|IN-6273-G;n:type:ShaderForge.SFN_Add,id:5897,x:33690,y:32716,varname:node_5897,prsc:2|A-4289-OUT,B-4521-OUT;n:type:ShaderForge.SFN_Multiply,id:4521,x:33282,y:32998,varname:node_4521,prsc:2|A-34-UVOUT,B-2066-OUT;n:type:ShaderForge.SFN_ValueProperty,id:2066,x:33056,y:32998,ptovrint:False,ptlb:Value,ptin:_Value,varname:_Value,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.5;n:type:ShaderForge.SFN_Tex2dAsset,id:8531,x:33964,y:32504,ptovrint:False,ptlb:Caustic,ptin:_Caustic,varname:_Caustic,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:f7efca784bbd4074c8e90c1b8d2f1502,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:2234,x:33937,y:32716,varname:_node_2234,prsc:2,tex:f7efca784bbd4074c8e90c1b8d2f1502,ntxv:0,isnm:False|UVIN-5897-OUT,TEX-8531-TEX;n:type:ShaderForge.SFN_Subtract,id:278,x:34157,y:32743,varname:node_278,prsc:2|A-2234-RGB,B-1798-OUT;n:type:ShaderForge.SFN_OneMinus,id:1798,x:33912,y:32896,varname:node_1798,prsc:2|IN-4061-OUT;n:type:ShaderForge.SFN_Slider,id:4061,x:33522,y:32968,ptovrint:False,ptlb:Thikness,ptin:_Thikness,varname:_Thikness,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Multiply,id:8443,x:34263,y:32984,varname:node_8443,prsc:2|A-278-OUT,B-82-OUT;n:type:ShaderForge.SFN_Slider,id:82,x:33889,y:33093,ptovrint:False,ptlb:Opacity,ptin:_Opacity,varname:_Opacity,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Multiply,id:1922,x:34383,y:33131,varname:node_1922,prsc:2|A-8443-OUT,B-8503-RGB;n:type:ShaderForge.SFN_VertexColor,id:8503,x:34082,y:33201,varname:node_8503,prsc:2;n:type:ShaderForge.SFN_Time,id:1099,x:32689,y:32580,varname:node_1099,prsc:2;n:type:ShaderForge.SFN_ValueProperty,id:7000,x:32689,y:32777,ptovrint:False,ptlb:CausticSpeed,ptin:_CausticSpeed,varname:_CausticSpeed,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Multiply,id:8639,x:32889,y:32553,varname:node_8639,prsc:2|A-1099-T,B-7000-OUT;n:type:ShaderForge.SFN_Add,id:1337,x:34588,y:32939,varname:node_1337,prsc:2|A-4715-RGB,B-1922-OUT;proporder:8632-7236-9479-6770-8440-3490-7347-3672-8349-2252-7107-4715-9156-7403-6273-2066-8531-4061-82-7000;pass:END;sub:END;*/

Shader "Animmal/WaterWCaustic_Shader" {
    Properties {
        _Color ("Color", Color) = (0.4779412,0.7839757,1,1)
        _NoiseTexture ("Noise Texture", 2D) = "gray" {}
        _Refraction ("Refraction", Range(-1, 1)) = 0.4700855
        _Speed ("Speed", Float ) = 0
        _WaveSpread ("WaveSpread", Float ) = 0
        _WaveWidth ("WaveWidth", Float ) = 10
        _WaveCount ("WaveCount", Float ) = 10
        _WaveHeight ("WaveHeight", Range(0, 1)) = 0.073
        _WaveDistortionNoise ("WaveDistortionNoise", 2D) = "white" {}
        _WaveSpeed ("WaveSpeed", Float ) = 10
        _Tessellation ("Tessellation", Range(0, 10)) = 0
        _EmissionColor ("EmissionColor", Color) = (0.4779412,0.7839757,1,1)
        _FresnelAmount ("Fresnel Amount", Range(0, 1)) = 0
        _Intensity ("Intensity", Range(0, 1)) = 0
        _Noise ("Noise", 2D) = "white" {}
        _Value ("Value", Float ) = 0.5
        _Caustic ("Caustic", 2D) = "white" {}
        _Thikness ("Thikness", Range(0, 1)) = 0
        _Opacity ("Opacity", Range(0, 1)) = 0
        _CausticSpeed ("CausticSpeed", Float ) = 0
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        LOD 200
        GrabPass{ }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend SrcAlpha OneMinusSrcAlpha
            ZWrite Off
            
            CGPROGRAM
            #pragma hull hull
            #pragma domain domain
            #pragma vertex tessvert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #include "Tessellation.cginc"
            #pragma multi_compile_fwdbase
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 5.0
            uniform float4 _LightColor0;
            uniform sampler2D _GrabTexture;
            uniform float4 _Color;
            uniform sampler2D _NoiseTexture; uniform float4 _NoiseTexture_ST;
            uniform float _Refraction;
            uniform float _Speed;
            uniform float _WaveSpread;
            uniform float _WaveWidth;
            uniform float _WaveCount;
            uniform float _WaveHeight;
            uniform sampler2D _WaveDistortionNoise; uniform float4 _WaveDistortionNoise_ST;
            uniform float _WaveSpeed;
            uniform float _Tessellation;
            uniform float4 _EmissionColor;
            uniform float _FresnelAmount;
            uniform float _Intensity;
            uniform sampler2D _Noise; uniform float4 _Noise_ST;
            uniform float _Value;
            uniform sampler2D _Caustic; uniform float4 _Caustic_ST;
            uniform float _Thikness;
            uniform float _Opacity;
            uniform float _CausticSpeed;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float4 vertexColor : COLOR;
                float4 projPos : TEXCOORD3;
                UNITY_FOG_COORDS(4)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.vertexColor = v.vertexColor;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                float4 node_41 = _Time;
                float2 node_216 = (o.uv0+node_41.g*float2(0.5,0.5));
                float4 _WaveDistortionNoise_var = tex2Dlod(_WaveDistortionNoise,float4(TRANSFORM_TEX(node_216, _WaveDistortionNoise),0.0,0));
                float4 node_194 = _Time;
                v.vertex.xyz += float3(float2(0.0,((_WaveDistortionNoise_var.r*(((sin(((mul(unity_ObjectToWorld, v.vertex).r+(node_194.r*_WaveSpeed))*_WaveCount))*_WaveSpread)+_WaveWidth)*0.5+0.5))*_WaveHeight)),0.0);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                return o;
            }
            #ifdef UNITY_CAN_COMPILE_TESSELLATION
                struct TessVertex {
                    float4 vertex : INTERNALTESSPOS;
                    float3 normal : NORMAL;
                    float4 tangent : TANGENT;
                    float2 texcoord0 : TEXCOORD0;
                    float4 vertexColor : COLOR;
                };
                struct OutputPatchConstant {
                    float edge[3]         : SV_TessFactor;
                    float inside          : SV_InsideTessFactor;
                    float3 vTangent[4]    : TANGENT;
                    float2 vUV[4]         : TEXCOORD;
                    float3 vTanUCorner[4] : TANUCORNER;
                    float3 vTanVCorner[4] : TANVCORNER;
                    float4 vCWts          : TANWEIGHTS;
                };
                TessVertex tessvert (VertexInput v) {
                    TessVertex o;
                    o.vertex = v.vertex;
                    o.normal = v.normal;
                    o.tangent = v.tangent;
                    o.texcoord0 = v.texcoord0;
                    o.vertexColor = v.vertexColor;
                    return o;
                }
                float Tessellation(TessVertex v){
                    return _Tessellation;
                }
                float4 Tessellation(TessVertex v, TessVertex v1, TessVertex v2){
                    float tv = Tessellation(v);
                    float tv1 = Tessellation(v1);
                    float tv2 = Tessellation(v2);
                    return float4( tv1+tv2, tv2+tv, tv+tv1, tv+tv1+tv2 ) / float4(2,2,2,3);
                }
                OutputPatchConstant hullconst (InputPatch<TessVertex,3> v) {
                    OutputPatchConstant o = (OutputPatchConstant)0;
                    float4 ts = Tessellation( v[0], v[1], v[2] );
                    o.edge[0] = ts.x;
                    o.edge[1] = ts.y;
                    o.edge[2] = ts.z;
                    o.inside = ts.w;
                    return o;
                }
                [domain("tri")]
                [partitioning("fractional_odd")]
                [outputtopology("triangle_cw")]
                [patchconstantfunc("hullconst")]
                [outputcontrolpoints(3)]
                TessVertex hull (InputPatch<TessVertex,3> v, uint id : SV_OutputControlPointID) {
                    return v[id];
                }
                [domain("tri")]
                VertexOutput domain (OutputPatchConstant tessFactors, const OutputPatch<TessVertex,3> vi, float3 bary : SV_DomainLocation) {
                    VertexInput v = (VertexInput)0;
                    v.vertex = vi[0].vertex*bary.x + vi[1].vertex*bary.y + vi[2].vertex*bary.z;
                    v.normal = vi[0].normal*bary.x + vi[1].normal*bary.y + vi[2].normal*bary.z;
                    v.tangent = vi[0].tangent*bary.x + vi[1].tangent*bary.y + vi[2].tangent*bary.z;
                    v.texcoord0 = vi[0].texcoord0*bary.x + vi[1].texcoord0*bary.y + vi[2].texcoord0*bary.z;
                    v.vertexColor = vi[0].vertexColor*bary.x + vi[1].vertexColor*bary.y + vi[2].vertexColor*bary.z;
                    VertexOutput o = vert(v);
                    return o;
                }
            #endif
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float4 node_6843 = _Time;
                fixed2 node_7958 = (i.uv0+(node_6843.g*_Speed)*float2(0.1,0.1));
                float4 _NoiseTexture_var = tex2D(_NoiseTexture,TRANSFORM_TEX(node_7958, _NoiseTexture));
                float2 sceneUVs = (i.projPos.xy / i.projPos.w) + (_NoiseTexture_var.rgb.rr*_Refraction);
                float4 sceneColor = tex2D(_GrabTexture, sceneUVs);
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = 1;
                float3 attenColor = attenuation * _LightColor0.xyz;
/////// Diffuse:
                float NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = max( 0.0, NdotL) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += UNITY_LIGHTMODEL_AMBIENT.rgb; // Ambient Light
                float3 diffuseColor = _Color.rgb;
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
////// Emissive:
                float4 node_1099 = _Time;
                float2 node_3201 = (i.uv0+(node_1099.g*_CausticSpeed)*float2(1,1));
                float3 _Noise_var = UnpackNormal(tex2D(_Noise,TRANSFORM_TEX(node_3201, _Noise)));
                float2 node_5897 = ((_Noise_var.g*0.1+0.0)+(i.uv0*_Value));
                float4 _node_2234 = tex2D(_Caustic,TRANSFORM_TEX(node_5897, _Caustic));
                float3 emissive = (_EmissionColor.rgb+(((_node_2234.rgb-(1.0 - _Thikness))*_Opacity)*i.vertexColor.rgb));
/// Final Color:
                float3 finalColor = diffuse + emissive;
                fixed4 finalRGBA = fixed4(lerp(sceneColor.rgb, finalColor,(pow(1.0-max(0,dot(i.normalDir, viewDirection)),_FresnelAmount)*_Intensity)),1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "FORWARD_DELTA"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            ZWrite Off
            
            CGPROGRAM
            #pragma hull hull
            #pragma domain domain
            #pragma vertex tessvert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Tessellation.cginc"
            #pragma multi_compile_fwdadd
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 5.0
            uniform float4 _LightColor0;
            uniform sampler2D _GrabTexture;
            uniform float4 _Color;
            uniform sampler2D _NoiseTexture; uniform float4 _NoiseTexture_ST;
            uniform float _Refraction;
            uniform float _Speed;
            uniform float _WaveSpread;
            uniform float _WaveWidth;
            uniform float _WaveCount;
            uniform float _WaveHeight;
            uniform sampler2D _WaveDistortionNoise; uniform float4 _WaveDistortionNoise_ST;
            uniform float _WaveSpeed;
            uniform float _Tessellation;
            uniform float4 _EmissionColor;
            uniform float _FresnelAmount;
            uniform float _Intensity;
            uniform sampler2D _Noise; uniform float4 _Noise_ST;
            uniform float _Value;
            uniform sampler2D _Caustic; uniform float4 _Caustic_ST;
            uniform float _Thikness;
            uniform float _Opacity;
            uniform float _CausticSpeed;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float4 vertexColor : COLOR;
                float4 projPos : TEXCOORD3;
                LIGHTING_COORDS(4,5)
                UNITY_FOG_COORDS(6)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.vertexColor = v.vertexColor;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                float4 node_7228 = _Time;
                float2 node_216 = (o.uv0+node_7228.g*float2(0.5,0.5));
                float4 _WaveDistortionNoise_var = tex2Dlod(_WaveDistortionNoise,float4(TRANSFORM_TEX(node_216, _WaveDistortionNoise),0.0,0));
                float4 node_194 = _Time;
                v.vertex.xyz += float3(float2(0.0,((_WaveDistortionNoise_var.r*(((sin(((mul(unity_ObjectToWorld, v.vertex).r+(node_194.r*_WaveSpeed))*_WaveCount))*_WaveSpread)+_WaveWidth)*0.5+0.5))*_WaveHeight)),0.0);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            #ifdef UNITY_CAN_COMPILE_TESSELLATION
                struct TessVertex {
                    float4 vertex : INTERNALTESSPOS;
                    float3 normal : NORMAL;
                    float4 tangent : TANGENT;
                    float2 texcoord0 : TEXCOORD0;
                    float4 vertexColor : COLOR;
                };
                struct OutputPatchConstant {
                    float edge[3]         : SV_TessFactor;
                    float inside          : SV_InsideTessFactor;
                    float3 vTangent[4]    : TANGENT;
                    float2 vUV[4]         : TEXCOORD;
                    float3 vTanUCorner[4] : TANUCORNER;
                    float3 vTanVCorner[4] : TANVCORNER;
                    float4 vCWts          : TANWEIGHTS;
                };
                TessVertex tessvert (VertexInput v) {
                    TessVertex o;
                    o.vertex = v.vertex;
                    o.normal = v.normal;
                    o.tangent = v.tangent;
                    o.texcoord0 = v.texcoord0;
                    o.vertexColor = v.vertexColor;
                    return o;
                }
                float Tessellation(TessVertex v){
                    return _Tessellation;
                }
                float4 Tessellation(TessVertex v, TessVertex v1, TessVertex v2){
                    float tv = Tessellation(v);
                    float tv1 = Tessellation(v1);
                    float tv2 = Tessellation(v2);
                    return float4( tv1+tv2, tv2+tv, tv+tv1, tv+tv1+tv2 ) / float4(2,2,2,3);
                }
                OutputPatchConstant hullconst (InputPatch<TessVertex,3> v) {
                    OutputPatchConstant o = (OutputPatchConstant)0;
                    float4 ts = Tessellation( v[0], v[1], v[2] );
                    o.edge[0] = ts.x;
                    o.edge[1] = ts.y;
                    o.edge[2] = ts.z;
                    o.inside = ts.w;
                    return o;
                }
                [domain("tri")]
                [partitioning("fractional_odd")]
                [outputtopology("triangle_cw")]
                [patchconstantfunc("hullconst")]
                [outputcontrolpoints(3)]
                TessVertex hull (InputPatch<TessVertex,3> v, uint id : SV_OutputControlPointID) {
                    return v[id];
                }
                [domain("tri")]
                VertexOutput domain (OutputPatchConstant tessFactors, const OutputPatch<TessVertex,3> vi, float3 bary : SV_DomainLocation) {
                    VertexInput v = (VertexInput)0;
                    v.vertex = vi[0].vertex*bary.x + vi[1].vertex*bary.y + vi[2].vertex*bary.z;
                    v.normal = vi[0].normal*bary.x + vi[1].normal*bary.y + vi[2].normal*bary.z;
                    v.tangent = vi[0].tangent*bary.x + vi[1].tangent*bary.y + vi[2].tangent*bary.z;
                    v.texcoord0 = vi[0].texcoord0*bary.x + vi[1].texcoord0*bary.y + vi[2].texcoord0*bary.z;
                    v.vertexColor = vi[0].vertexColor*bary.x + vi[1].vertexColor*bary.y + vi[2].vertexColor*bary.z;
                    VertexOutput o = vert(v);
                    return o;
                }
            #endif
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float4 node_6843 = _Time;
                fixed2 node_7958 = (i.uv0+(node_6843.g*_Speed)*float2(0.1,0.1));
                float4 _NoiseTexture_var = tex2D(_NoiseTexture,TRANSFORM_TEX(node_7958, _NoiseTexture));
                float2 sceneUVs = (i.projPos.xy / i.projPos.w) + (_NoiseTexture_var.rgb.rr*_Refraction);
                float4 sceneColor = tex2D(_GrabTexture, sceneUVs);
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
/////// Diffuse:
                float NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = max( 0.0, NdotL) * attenColor;
                float3 diffuseColor = _Color.rgb;
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse;
                fixed4 finalRGBA = fixed4(finalColor * (pow(1.0-max(0,dot(i.normalDir, viewDirection)),_FresnelAmount)*_Intensity),0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "ShadowCaster"
            Tags {
                "LightMode"="ShadowCaster"
            }
            Offset 1, 1
            Cull Back
            
            CGPROGRAM
            #pragma hull hull
            #pragma domain domain
            #pragma vertex tessvert
            #pragma fragment frag
            #define UNITY_PASS_SHADOWCASTER
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "Tessellation.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 5.0
            uniform float _WaveSpread;
            uniform float _WaveWidth;
            uniform float _WaveCount;
            uniform float _WaveHeight;
            uniform sampler2D _WaveDistortionNoise; uniform float4 _WaveDistortionNoise_ST;
            uniform float _WaveSpeed;
            uniform float _Tessellation;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
                float2 uv0 : TEXCOORD1;
                float4 posWorld : TEXCOORD2;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                float4 node_483 = _Time;
                float2 node_216 = (o.uv0+node_483.g*float2(0.5,0.5));
                float4 _WaveDistortionNoise_var = tex2Dlod(_WaveDistortionNoise,float4(TRANSFORM_TEX(node_216, _WaveDistortionNoise),0.0,0));
                float4 node_194 = _Time;
                v.vertex.xyz += float3(float2(0.0,((_WaveDistortionNoise_var.r*(((sin(((mul(unity_ObjectToWorld, v.vertex).r+(node_194.r*_WaveSpeed))*_WaveCount))*_WaveSpread)+_WaveWidth)*0.5+0.5))*_WaveHeight)),0.0);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityObjectToClipPos( v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            #ifdef UNITY_CAN_COMPILE_TESSELLATION
                struct TessVertex {
                    float4 vertex : INTERNALTESSPOS;
                    float3 normal : NORMAL;
                    float4 tangent : TANGENT;
                    float2 texcoord0 : TEXCOORD0;
                };
                struct OutputPatchConstant {
                    float edge[3]         : SV_TessFactor;
                    float inside          : SV_InsideTessFactor;
                    float3 vTangent[4]    : TANGENT;
                    float2 vUV[4]         : TEXCOORD;
                    float3 vTanUCorner[4] : TANUCORNER;
                    float3 vTanVCorner[4] : TANVCORNER;
                    float4 vCWts          : TANWEIGHTS;
                };
                TessVertex tessvert (VertexInput v) {
                    TessVertex o;
                    o.vertex = v.vertex;
                    o.normal = v.normal;
                    o.tangent = v.tangent;
                    o.texcoord0 = v.texcoord0;
                    return o;
                }
                float Tessellation(TessVertex v){
                    return _Tessellation;
                }
                float4 Tessellation(TessVertex v, TessVertex v1, TessVertex v2){
                    float tv = Tessellation(v);
                    float tv1 = Tessellation(v1);
                    float tv2 = Tessellation(v2);
                    return float4( tv1+tv2, tv2+tv, tv+tv1, tv+tv1+tv2 ) / float4(2,2,2,3);
                }
                OutputPatchConstant hullconst (InputPatch<TessVertex,3> v) {
                    OutputPatchConstant o = (OutputPatchConstant)0;
                    float4 ts = Tessellation( v[0], v[1], v[2] );
                    o.edge[0] = ts.x;
                    o.edge[1] = ts.y;
                    o.edge[2] = ts.z;
                    o.inside = ts.w;
                    return o;
                }
                [domain("tri")]
                [partitioning("fractional_odd")]
                [outputtopology("triangle_cw")]
                [patchconstantfunc("hullconst")]
                [outputcontrolpoints(3)]
                TessVertex hull (InputPatch<TessVertex,3> v, uint id : SV_OutputControlPointID) {
                    return v[id];
                }
                [domain("tri")]
                VertexOutput domain (OutputPatchConstant tessFactors, const OutputPatch<TessVertex,3> vi, float3 bary : SV_DomainLocation) {
                    VertexInput v = (VertexInput)0;
                    v.vertex = vi[0].vertex*bary.x + vi[1].vertex*bary.y + vi[2].vertex*bary.z;
                    v.normal = vi[0].normal*bary.x + vi[1].normal*bary.y + vi[2].normal*bary.z;
                    v.tangent = vi[0].tangent*bary.x + vi[1].tangent*bary.y + vi[2].tangent*bary.z;
                    v.texcoord0 = vi[0].texcoord0*bary.x + vi[1].texcoord0*bary.y + vi[2].texcoord0*bary.z;
                    VertexOutput o = vert(v);
                    return o;
                }
            #endif
            float4 frag(VertexOutput i) : COLOR {
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
