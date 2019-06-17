#version 330 core
out vec4 FragColor;

// uniform vec4 ourColor;

in vec4 ourPosition;

void main()
{
    FragColor = ourPosition;
}