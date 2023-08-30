#version 100

precision mediump float;

// Input vertex attributes (from vertex shader)
varying vec2 fragTexCoord;
varying vec4 fragColor;

uniform vec2 screenDims;        // Dimensions of the screen
uniform vec2 c;                 // c.x = real, c.y = imaginary component. Equation done is z^2 + c
uniform vec2 offset;            // Offset of the scale.
uniform float zoom;             // Zoom of the scale.

// Convert Hue Saturation Value (HSV) color into RGB
vec3 Hsv2rgb(vec3 c)
{
    vec4 K = vec4(1.0, 2.0 / 3.0, 1.0 / 3.0, 3.0);
    vec3 p = abs(fract(c.xxx + K.xyz) * 6.0 - K.www);
    return c.z * mix(K.xxx, clamp(p - K.xxx, 0.0, 1.0), c.y);
}

void main()
{
    gl_FragColor = vec4(Hsv2rgb(vec3(0.6, 0.8, 0.5)), 1.0);
}
