#version 330 core
out vec4 FragColor;

// uniform vec4 ourColor;

in vec3 ourColor;
in vec2 TexCoord;

uniform sampler2D texture1;
uniform sampler2D texture2;

void main()
{
    FragColor = mix(texture(texture1, TexCoord * 2.0), texture(texture2, vec2(TexCoord.x * 2.0, TexCoord.y * 2.0)), 0.2);
    // FragColor = texture(ourTexture, TexCoord) * vec4(ourColor, 1.0);
}