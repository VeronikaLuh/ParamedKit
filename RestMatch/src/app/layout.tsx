'use client'
import "./globals.scss";
import React from "react";
import Header from "@/components/common/Header";
import Footer from "@/components/common/Footer";
import HeaderM from "@/components/common/HeaderM";

export default function RootLayout(
  {
    children,
  }: Readonly<{
    children: React.ReactNode;
  }>) {
  return (
    <html lang="en">
    <body>
    <Header/>
    {children}
    <Footer/>
    </body>
    </html>
  );
}
