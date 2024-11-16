'use client'
import "./globals.scss";
import React from "react";
import Header from "@/components/common/Header";

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
    </body>
    </html>
  );
}
