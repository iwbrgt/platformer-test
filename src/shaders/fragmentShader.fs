#version 330 core
out vec4 FragColor;
  
in vec2 TexCoord;

uniform sampler2D spritesheet;

void main()
{
    FragColor = texture(spritesheet, TexCoord);
}