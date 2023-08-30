#version 100

precision mediump float;

// Input vertex attributes (from vertex shader)
varying vec2 fragTexCoord;           // Texture coordinates (sampler2D)
varying vec4 fragColor;              // Tint color

// Uniform inputs
uniform vec2 resolution;        // Viewport resolution (in pixels)
uniform vec2 mouse;             // Mouse pixel xy coordinates
uniform float time;             // Total run time (in secods)

// Draw circle
vec4 DrawCircle(vec2 fragCoord, vec2 position, float radius, vec3 color)
{
    float d = length(position - fragCoord) - radius;
    float t = clamp(d, 0.0, 1.0);
    return vec4(color, 1.0 - t);
}

void main()
{
    vec2 fragCoord = gl_FragCoord.xy;
    vec2 position = vec2(mouse.x, resolution.y - mouse.y);

    // Blend the two layers
    gl_FragColor = vec4(0.8,0.1,0.8,1.0);
}
