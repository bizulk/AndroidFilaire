#ifndef LIBCOMM_GLOBAL_H
#define LIBCOMM_GLOBAL_H

#if defined(_MSC_VER) || defined(WIN64) || defined(_WIN64) || defined(__WIN64__) || defined(WIN32) || defined(_WIN32) || defined(__WIN32__) || defined(__NT__)
#  define Q_DECL_EXPORT __declspec(dllexport)
#  define Q_DECL_IMPORT __declspec(dllimport)
#else
#  define Q_DECL_EXPORT     __attribute__((visibility("default")))
#  define Q_DECL_IMPORT     __attribute__((visibility("default")))
#endif

#if defined(LIBCOMM_LIBRARY)
#  define LIBCOMM_EXPORT Q_DECL_EXPORT
#else
#  define LIBCOMM_EXPORT Q_DECL_IMPORT
#endif

// Pour le parse par CFFI (python) ou SWIG il faut désactiver le symbole qui ne peut être traité
#ifdef SWIG_FFI_BINDING
#undef LIBCOMM_EXPORT
#define LIBCOMM_EXPORT
#endif

#endif // LIBCOMM_GLOBAL_H
