import js from '@eslint/js';

export default [
    {
        files: ['wwwroot/js/**/*.js'],

        languageOptions: {
            globals: {
                window: 'readonly',
                document: 'readonly',
                console: 'readonly',
                $: 'readonly',
                jQuery: 'readonly',
                bootstrap: 'readonly',
                fetch: 'readonly',
                URL: 'readonly',
                URLSearchParams: 'readonly',
                FormData: 'readonly',
                setTimeout: 'readonly',
                clearTimeout: 'readonly'
            }
        },

        ...js.configs.recommended
    }
];