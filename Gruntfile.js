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
          src: ['**/*.html', 'scripts/three.min.js', 'scripts/typeface.min.js'],
          dest: ''
      }
    },
    concat: {
        main:{
          files:[
             {
              dest: 'scripts/game.js',
              src: [ 'dev/scripts/jquery.min.js', 'dev/scripts/game.js', 'dev/scripts/sweet-alert.js', 'dev/scripts/random-color.js']
              }
             ]
        }
    },
    uglify:{
      options :  {
        mangle :  false
      },
      main: {
        files: [
                { dest: 'scripts/game.js',
                    src: [ 'scripts/game.js' ] },
                { dest: 'scripts/home.js',
                   src: [ 'dev/scripts/home.js' ] }
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