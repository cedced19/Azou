module.exports = function(grunt) {
  require('time-grunt')(grunt);
  var config = {
    usemin: {
        html: ['index.html', 'game.html']
    },
    htmlmin: {
            dist: {
              options: {
                removeComments: true,
                collapseWhitespace: true
              },
              files: {
                'index.html': 'index.html',
                'game.html': 'game.html'
              }
          }
    },
    copy: {
      main: {
          expand: true,
          cwd: 'dev/',
          src: ['**/*.html', 'scripts/home/three.min.js', 'scripts/home/typeface.min.js'],
          dest: ''
      }
    },
    concat: {
        main:{
          files:[
             {
              dest: 'scripts/game.js',
              src: [ 'dev/scripts/game/jquery.min.js', 'dev/scripts/game/sweet-alert.js', 'dev/scripts/game/random-color.js', 'dev/scripts/game/index.js']
              }
             ]
        }
    },
    uglify: {
      options:  {
        mangle:  false
      },
      main: {
        files: [
                { dest: 'scripts/game.js',
                    src: [ 'scripts/game.js' ] },
                { dest: 'scripts/home/index.js',
                   src: [ 'dev/scripts/home/index.js' ] }
               ]
             }
       },
      cssmin: {
        main: {
          files: {
            'styles/styles.css': ['dev/styles/game.css', 'dev/styles/home.css', 'dev/styles/sweet-alert.css']
          }
        }
      },
      autoprefixer: {
          main: {
            expand: true,
            flatten: true,
            src: 'styles/*.css',
            dest: 'styles/'
          }
      }
};

  grunt.initConfig(config);

  // Load all Grunt tasks
  require('matchdep').filterDev('grunt-*').forEach(grunt.loadNpmTasks);
  grunt.registerTask('default', ['copy', 'usemin', 'htmlmin', 'concat', 'uglify', 'cssmin', 'autoprefixer']);
};