cmake_minimum_required(VERSION 3.10)

project(myshader)

# Add your source file
add_executable(myshader main.c)

# Add the define for DRM platform
target_compile_definitions(myshader PRIVATE PLATFORM_DRM)

# Link against the required libraries
target_link_libraries(myshader PRIVATE raylib m dl pthread drm rt gbm GL EGL)

